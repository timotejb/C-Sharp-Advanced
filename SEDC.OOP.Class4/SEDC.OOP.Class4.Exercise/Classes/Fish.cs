using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Exercise.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The Fish {Name}, type {Type}, age {Age}. Color: {Color}, Size: {Size}");
        }
    }
}
