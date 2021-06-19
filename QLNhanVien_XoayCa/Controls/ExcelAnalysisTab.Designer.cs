namespace QLNhanVien_XoayCa.Controls
{
    partial class ExcelAnalysisTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegressionF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSaveDb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSheet = new System.Windows.Forms.ComboBox();
            this.btnTimeSeriesF = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbbColumn = new System.Windows.Forms.ComboBox();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chartItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(566, 401);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRegressionF
            // 
            this.btnRegressionF.Location = new System.Drawing.Point(621, 158);
            this.btnRegressionF.Name = "btnRegressionF";
            this.btnRegressionF.Size = new System.Drawing.Size(149, 23);
            this.btnRegressionF.TabIndex = 2;
            this.btnRegressionF.Text = "Regression Forecast";
            this.btnRegressionF.UseVisualStyleBackColor = true;
            this.btnRegressionF.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value:";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(575, 240);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(195, 20);
            this.tbValue.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(621, 133);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(814, 452);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnUpload);
            this.tabPage1.Controls.Add(this.btnSaveDb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbbSheet);
            this.tabPage1.Controls.Add(this.btnTimeSeriesF);
            this.tabPage1.Controls.Add(this.btnChooseFile);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnRegressionF);
            this.tabPage1.Controls.Add(this.tbValue);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Convert to XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnToXML_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(616, 58);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSaveDb
            // 
            this.btnSaveDb.Location = new System.Drawing.Point(697, 58);
            this.btnSaveDb.Name = "btnSaveDb";
            this.btnSaveDb.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDb.TabIndex = 11;
            this.btnSaveDb.Text = "Save Db";
            this.btnSaveDb.UseVisualStyleBackColor = true;
            this.btnSaveDb.Click += new System.EventHandler(this.btnSaveDb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sheet:";
            // 
            // cbbSheet
            // 
            this.cbbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSheet.FormattingEnabled = true;
            this.cbbSheet.Location = new System.Drawing.Point(621, 33);
            this.cbbSheet.Margin = new System.Windows.Forms.Padding(2);
            this.cbbSheet.Name = "cbbSheet";
            this.cbbSheet.Size = new System.Drawing.Size(152, 21);
            this.cbbSheet.TabIndex = 9;
            // 
            // btnTimeSeriesF
            // 
            this.btnTimeSeriesF.Location = new System.Drawing.Point(621, 187);
            this.btnTimeSeriesF.Name = "btnTimeSeriesF";
            this.btnTimeSeriesF.Size = new System.Drawing.Size(149, 23);
            this.btnTimeSeriesF.TabIndex = 8;
            this.btnTimeSeriesF.Text = "TimeSeries Forecast";
            this.btnTimeSeriesF.UseVisualStyleBackColor = true;
            this.btnTimeSeriesF.Click += new System.EventHandler(this.btnTimeSeriesF_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(575, 3);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.cbbColumn);
            this.tabPage2.Controls.Add(this.btnGenerateChart);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(806, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected Column:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(556, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // cbbColumn
            // 
            this.cbbColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbColumn.FormattingEnabled = true;
            this.cbbColumn.Location = new System.Drawing.Point(568, 265);
            this.cbbColumn.Name = "cbbColumn";
            this.cbbColumn.Size = new System.Drawing.Size(202, 21);
            this.cbbColumn.TabIndex = 1;
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnGenerateChart.Location = new System.Drawing.Point(661, 378);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(109, 23);
            this.btnGenerateChart.TabIndex = 0;
            this.btnGenerateChart.Text = "Generate Chart";
            this.btnGenerateChart.UseVisualStyleBackColor = true;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(764, 237);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ExcelAnalysisTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "ExcelAnalysisTab";
            this.Size = new System.Drawing.Size(1180, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegressionF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnTimeSeriesF;
        private System.Windows.Forms.Button btnSaveDb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSheet;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbbColumn;
        private System.Windows.Forms.Button btnGenerateChart;
        private System.Windows.Forms.BindingSource chartItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}
