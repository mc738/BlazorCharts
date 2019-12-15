using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.LineCharts
{
    public class Ranges
    {
        private Dictionary<string, Range> items { get; set; }
        public IEnumerable<Range> Items => items.Values;

        public Ranges()
        {

            items = new Dictionary<string, Range>();
        }

        public void AddRange(Range range)
        {
            if (items.ContainsKey(range.Name))
                items[range.Name] = range;
            else
                items.Add(range.Name, range);
        }
    }
}
