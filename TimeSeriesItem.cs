using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts
{
    public class TimeSeriesItem
    {
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int RenderValue { get; private set; }


        public void Render(decimal max)
        {
            RenderValue = decimal.ToInt32((Value / max) * 100);
        }
    }
}
