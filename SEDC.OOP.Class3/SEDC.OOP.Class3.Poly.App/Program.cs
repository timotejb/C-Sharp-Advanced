using System;
using SEDC.OOP.Class3.Poly.App.Enteties;
using System.Collections.Generic;
namespace SEDC.OOP.Class3.Poly.App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>()
            {
                new Cat("Meow", 2),
                new Dog("Af", "German sheperd")
            };
        }
    }
}
