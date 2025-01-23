using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovDZ
{
    class Building
    {
        public string Name { get; set; }
        public int Floors { get; set; }

        public Building(string name, int floors)
        {
            Name = name;
            Floors = floors;
        }

        public override string ToString()
        {
            return $"Здание: {Name}, Этажи: {Floors}";
        }
    }
}
