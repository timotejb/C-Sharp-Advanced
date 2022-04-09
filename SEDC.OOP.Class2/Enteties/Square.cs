using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Square:Figure
    {
        public int Side { get; set; }
        public Square (int side)
        {
            Side = side;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
