using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCharts.PieCharts
{
    public class Slices
    {
        private Dictionary<string, Slice> items { get; set; }

        public IEnumerable<Slice> Items => items.Values;

        public Slices()
        {
            items = new Dictionary<string, Slice>();
        }
      
        public void AddSlice(Slice slice)
        {
            if (items.ContainsKey(slice.Name))
                items[slice.Name] = slice;
            else
                items.Add(slice.Name, slice);
        }
    }
}
