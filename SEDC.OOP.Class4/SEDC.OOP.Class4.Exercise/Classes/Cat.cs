using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Exercise.Classes
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The Cat {Name}, type {Type}, age {Age}. IsLazy: {IsLazy}, Lives left: {LivesLeft}");

        }
    }
}
