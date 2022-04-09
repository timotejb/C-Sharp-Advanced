using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.Class3.Poly.App.Enteties
{
    public class Cat : Pet
    {
        public int NumberOfBalls { get; set; }
        public Cat(string name, int numberOfBalls ) : base(name)
        {
            NumberOfBalls = numberOfBalls;
        }
        public override void Eat()
        {
            Console.WriteLine("The cat is eating");
        }
    }
}
