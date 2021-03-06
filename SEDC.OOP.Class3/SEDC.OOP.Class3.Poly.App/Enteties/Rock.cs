using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.Class3.Poly.App.Enteties
{
    public class Dog : Pet
    {
        public string Type { get; set; }
        public Dog() : base("Sharko")
        {

        }

        public Dog(string name) : base(name)
        {

        }

        public Dog(int number) : base("1234")
        {
            Console.WriteLine(number);
        }

        public Dog(string name, string type) : base(name)
        {
            Type = type;
        }
        public override void Eat()
        {
            Console.WriteLine("The dog is eating");
        }
    }
}
