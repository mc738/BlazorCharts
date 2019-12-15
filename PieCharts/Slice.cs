using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.PieCharts
{
    public class Slice
    {
        private ArchCommand command { get; set; }

        public string Name { get; private set; }
        public string Color { get; private set; }
        public int Value { get; private set; }
        public string Command => command.Command;



        public Slice(string name, string color, int value, ArchCommand command)
        {
            Name = name;
            Color = color;
            Value = value;
            this.command = command;
        }
    }
}
