using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.LineCharts
{
    public class Line
    {
        public double Length { get; private set; }
        public double Angle { get; private set; }

        public Line(Point pointA, Point pointB)
        {
            var lengthX = pointB.X - pointA.X;
            var lengthY = pointB.Y - pointA.Y;

            Length = Math.Sqrt(Math.Pow(lengthX, 2) + Math.Pow(lengthY, 2));
            Angle = Math.Atan2(lengthY, lengthX);
        }
    }
}
