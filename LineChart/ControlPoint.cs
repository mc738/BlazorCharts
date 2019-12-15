using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.LineCharts
{
    public class ControlPoint
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public ControlPoint(Point current, Point previous = null, Point next = null, bool reverse = false)
        {
            if (previous == null)
                previous = current;

            if (next == null)
                next = current;

            var smoothing = 0.15;

            var opLine = new Line(previous, next);

            double angle = opLine.Angle;
            double length = opLine.Length;

            if (reverse)
                angle = opLine.Angle + Math.PI;

            length = opLine.Length * smoothing;

            X = current.X + (int)(Math.Cos(angle) * length);
            Y = current.Y + (int)(Math.Sin(angle) * length);
        }
    }
}
