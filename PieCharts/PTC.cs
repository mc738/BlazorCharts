using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.PieCharts
{
    public class PTC
    {
        // https://stackoverflow.com/questions/5736398/how-to-calculate-the-svg-path-for-an-arc-of-a-circle

        public int X { get; private set; }
        public int Y { get; private set; }

        public PTC(int radius, int centerX, int centerY, int angleInDegrees)
        {
            var angleInRadians = (angleInDegrees - 90) * Math.PI / 180.0;

            X = centerX + (int)(radius * Math.Cos(angleInRadians));
            Y = centerY + (int)(radius * Math.Sin(angleInRadians));
        }
    }
}
