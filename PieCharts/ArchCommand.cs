using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.PieCharts
{
    public class ArchCommand
    {
        public string Command { get; private set; }

        public ArchCommand(int x, int y, int radius, int startAngle, int endAngle)
        {
            var start = new PTC(radius, x, y, endAngle);
            var end = new PTC(radius, x, y, startAngle);

            var largeArcFlag = endAngle - startAngle <= 180 ? 0 : 1;

            Command = $"M {start.X} {start.Y} A {radius} {radius} 0 {largeArcFlag} 0 {end.X} {end.Y}";

        }
    }
}
