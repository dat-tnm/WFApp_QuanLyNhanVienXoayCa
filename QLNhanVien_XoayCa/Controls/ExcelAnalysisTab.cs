using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Model;
using Excel = Microsoft.Office.Interop.Excel;
using MathNet.Numerics.LinearRegression;
using System.Data.OleDb;
using System.IO;

namespace QLNhanVien_XoayCa.Controls
{
    public partial class ExcelAnalysisTab : UserControl
    {
        ExcelDb db;
        DataTable dt;

        string filepath;
        string fileConStr;


        int column;
        int date_col;

        public ExcelAnalysisTab()
        {
            InitializeComponent();

            db = new ExcelDb();
            openFileDialog1.Filter = "Excel files | *.xls?";
        }








        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            column = e.ColumnIndex;
            var dt = (System.Data.DataTable)dataGridView1.DataSource;
            label1.Text = dt.Columns[column].ColumnName;
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            if (column == date_col)
            {
                return;
            }

            var dt = (System.Data.DataTable)dataGridView1.DataSource;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (dt.Columns[i].DataType == typeof(DateTime))
                {
                    date_col = i;
                    break;
                }
            }

            int month = dateTimePicker1.Value.Month;
            int day = dateTimePicker1.Value.Day;
            var rootDate = (DateTime)dt.Rows[0][date_col];
            TimeSpan ts = dateTimePicker1.Value - rootDate;
            TimeSpan ts_x;

            var tuples = new List<Tuple<double, double>>();
            double x, y;
            foreach (DataRow row in dt.Rows)
            {
                var row_date = (DateTime)row[date_col];
                double.TryParse(row[column].ToString(), out y);
                if (y == 0 || row_date.Month != month || row_date.Day < day - 1 || row_date.Day > day + 1)
                {
                    continue;
                }
                ts_x = row_date - rootDate;
                x = ts_x.TotalDays;
                tuples.Add(Tuple.Create(x, y));
            }
            if (tuples.Count < 2)
            {
                tbValue.Text = "Không đủ dữ liệu";
                return;
            }
            Tuple<double, double> result = SimpleRegression.Fit(tuples);
            double forcastvalue = result.Item1 + result.Item2 * ts.TotalDays;
            tbValue.Text = forcastvalue.ToString();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            filepath = openFileDialog1.FileName;
            fileConStr = string.Format(db.Excel07ConString, filepath);

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook excelBook = xlApp.Workbooks.Open(filepath);
            cbbSheet.Items.Clear();
            int i = 0;
            foreach (Excel.Worksheet wSheet in excelBook.Worksheets)
            {
                cbbSheet.Items.Add(wSheet.Name.ToString());
                i++;
            }
            excelBook.Close();
            xlApp.Workbooks.Close();
            cbbSheet.Text = cbbSheet.Items[0].ToString();
        }

        private void btnTimeSeriesF_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (fileConStr == null)
            {
                return;
            }

            using (OleDbConnection cn = new OleDbConnection(fileConStr))
            {
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from [" + cbbSheet.Text + "$]", cn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                try
                {
                    da.Fill(dt);
                }
                catch (Exception)
                {
                    return;
                }
                dataGridView1.DataSource = dt;
                fileConStr = null;
                cn.Close();
            }

            foreach (DataColumn col in dt.Columns)
            {
                if (col.DataType != typeof(DateTime))
                    cbbColumn.Items.Add(col.ColumnName);
            }
        }

        private void btnSaveDb_Click(object sender, EventArgs e)
        {
            if (dt != null)
            {
                db.SaveTableFromExcel(filepath, cbbSheet.Text);

                MessageBox.Show("Ghi dữ liệu thành công!");
            }
        }

        private void btnToXML_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                return;
            }

            string filename_nonextension = Path.GetFileNameWithoutExtension(filepath) + "_" + cbbSheet.Text;
            string path = Path.GetDirectoryName(filepath) + "\\\\" + filename_nonextension + ".xml";
            dt.TableName = filename_nonextension;
            dt.WriteXml(path);
        }

        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            var objChart = chart1.ChartAreas[0];
            //X line - month
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 12;
            //Y line - value
            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = 0;
            //clear
            chart1.Series.Clear();

            int colIndex = 0;
            foreach (DataColumn item in dt.Columns)
            {
                if (item.ColumnName == cbbColumn.Text)
                    break;

                colIndex++;
            }
            int rowIndex = 0;
            int last_month = ((DateTime)dt.Rows[0][date_col]).Month;
            int month;
            double max_value = Convert.ToDouble(dt.Rows[0][colIndex]);
            Chart_Item chart_item = new Chart_Item(((DateTime)dt.Rows[0][date_col]).Year);
            List<Chart_Item> chart_items = new List<Chart_Item>();
            List<double> values = new List<double>();
            double value;
            double average_value;
            int count;
            foreach (DataRow row in dt.Rows)
            {
                value = Convert.ToDouble(row[colIndex]);
                if (value == 0)
                {
                    continue;
                }

                if (value > max_value)
                {
                    max_value = value;
                }

                month = ((DateTime)dt.Rows[rowIndex][date_col]).Month;
                if (last_month == month)
                {
                    values.Add(value);
                }
                else
                {
                    count = 0;
                    average_value = 0;
                    foreach (double val in values)
                    {
                        average_value += val;
                        count++;
                    }

                    chart_item[last_month] = average_value /= count;

                    values.Clear();
                    values.Add(value);

                    if (chart_item.Year != ((DateTime)dt.Rows[rowIndex][date_col]).Year)
                    {
                        chart_items.Add(chart_item);
                        chart_item = new Chart_Item(((DateTime)dt.Rows[rowIndex][date_col]).Year);
                    }
                }

                rowIndex++;
                last_month = month;
            }

            chart_items.Add(chart_item);
            objChart.AxisY.Maximum = max_value - (max_value % 50) + 50;
            dataGridView2.DataSource = chart_items;

            Random random = new Random();
            string year;
            foreach (Chart_Item item in chart_items)
            {
                year = item.Year.ToString();
                chart1.Series.Add(year);
                chart1.Series[year].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                chart1.Series[year].Legend = "Legend1";
                chart1.Series[year].ChartArea = "ChartArea1";
                chart1.Series[year].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //adding data
                for (int i = 1; i <= 12; i++)
                {
                    if (item[i].ToString() == "0")
                        continue;
                    chart1.Series[year].Points.AddXY(i, item[i]);
                }
            }
        }

    }
}
