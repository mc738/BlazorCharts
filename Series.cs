using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts
{
    public class Series
    {
        public string Name { get; private set; }

        public string Color { get; private set; }
        public List<int> Values { get; private set; }

        public Series(string name, string color)
        {
            Name = name;
            Color = color;
            Values = new List<int>();
        }

        public void AddValue(int value)
        {
            Values.Add(value);
        }
    }
}
