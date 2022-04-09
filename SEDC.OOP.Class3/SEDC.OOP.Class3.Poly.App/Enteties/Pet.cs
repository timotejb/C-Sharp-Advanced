using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.Class3.Poly.App.Enteties
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public Pet(string name)
        {
            Name = name;
        }
        public abstract void Eat()
        {

        }
    }
}
