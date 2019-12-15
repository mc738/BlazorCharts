using BlazorCharts.LineCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorCharts
{
    public class TimeSeries
    {
        public List<TimeSeriesItem> Items { get; set; }

        public decimal MaxValue { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        public TimeSeries()
        {
            Items = new List<TimeSeriesItem>();
        }


        public void Render(decimal maxValue)
        {
            MaxValue = maxValue;

            foreach (var item in Items)
            {
                item.Render(MaxValue);
            }
        }
    }
}
