﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Exercise.Classes
{
    public abstract class Pet
    {
        public  string Name { get; set; }
        public  string Type { get; set; }   
        public  int Age { get; set; }
        public abstract void PrintInfo();
    
     }
}
