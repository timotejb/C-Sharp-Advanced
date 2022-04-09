using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Circle:Figure
    {
        public int Radius { get; set; } 
        public Circle (int radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Radius * Radius * 3.14;
        }
    }
}
