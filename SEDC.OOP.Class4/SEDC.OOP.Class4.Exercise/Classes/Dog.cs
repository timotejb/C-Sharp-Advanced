using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Exercise.Classes
{
    public class Dog : Pet
    {
        public bool IsGood { get; set; }
        public string FavFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"The Fish {Name}, type {Type}, age {Age}. Is Doggy good?: {IsGood}, Favourite food: {FavFood}");
        }


    }
}
