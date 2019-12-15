using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorCharts.LineCharts
{
    public class SVGPath
    {
        public string Value { get; private set; }

        public SVGPath(List<Point> points)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < points.Count(); i++)
            {
                if (i == 0)
                {
                    sb.Append($"M {points[i].X} {points[i].Y} ");
                }
                else
                {
                    sb.Append(new BezierCommand(points[i], i, points).Command);
                }
            }

            Value = sb.ToString();
        }
    }
}
