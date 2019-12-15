using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.LineCharts
{
    public class Range
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public SVGPath Path { get; private set; }

        public bool Show { get; set; } = true;
        public bool Highlighted { get; set; } = false;

        public Range(string name, string color, List<Point> points)
        {
            Name = name;
            Color = color;
            Path = new SVGPath(points);
        }


    }
}
