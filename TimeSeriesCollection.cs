using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorCharts
{
    public class TimeSeriesCollection
    {
        public Dictionary<string, TimeSeries> TimeSeries { get; set; }

        public IEnumerable<TimeSeries> Series => TimeSeries.Values;

        public decimal MaxValue { get; set; } = 1;

        public List<string> XLabels { get; set; }
        public List<string> YLabels { get; set; }
        public int XUnitCount { get; set; } = 10;
        public int YUnitCount { get; set; } = 10;

        public int Count => TimeSeries.Count();

        public TimeSeriesCollection()
        {
            TimeSeries = new Dictionary<string, TimeSeries>();
            XLabels = new List<string>();
            YLabels = new List<string>();
        }

        public void Render(decimal max)
        {

            MaxValue = max;

            foreach (var series in TimeSeries.Values)
            {
                series.Render(MaxValue);
            }
        }
    }
}
