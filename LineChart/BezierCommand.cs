using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorCharts.LineCharts
{
    public class BezierCommand
    {
        public string Command { get; private set; }

        public BezierCommand(Point point, int index, List<Point> points)
        {
            Point p = null;
            Point p2 = null;

            if (index - 2 > -1)
                p = points[index - 2];

            if (index + 1 < points.Count())
                p2 = points[index + 1];

            var startControlPoint = new ControlPoint(points[index - 1], p, point);
            var endControlPoint = new ControlPoint(points[index - 1], p2, point, true);

            Command = $"C {startControlPoint.X} {startControlPoint.Y} {endControlPoint.X} {endControlPoint.Y} {point.X} {point.Y}";
        }
    }
}
