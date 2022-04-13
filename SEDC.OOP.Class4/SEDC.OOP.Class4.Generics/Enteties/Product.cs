﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics.Enteties
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(Title + " - " + Description);
        }
        public override string ToString()
        {
            return Title + " - " + Description;
        }
    }
}
