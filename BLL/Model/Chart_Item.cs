using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Chart_Item
    {
        public Chart_Item()
        {

        }

        public Chart_Item(int year)
        {
            Year = year;
        }

        public int Year { get; set; }
        public double M1 { get; set; }
        public double M2 { get; set; }
        public double M3 { get; set; }
        public double M4 { get; set; }
        public double M5 { get; set; }
        public double M6 { get; set; }
        public double M7 { get; set; }
        public double M8 { get; set; }
        public double M9 { get; set; }
        public double M10 { get; set; }
        public double M11 { get; set; }
        public double M12 { get; set; }

        public object this[int month]
        {
            get { return this.GetType().GetProperty("M" + month).GetValue(this, null); }
            set { this.GetType().GetProperty("M" + month).SetValue(this, value, null); }
        }
    }
}
