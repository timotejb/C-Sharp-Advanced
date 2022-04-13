﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string LiscencePlate { get; set; }
        public DateTime LiscenceExpieryDate { get; set; }
        public List<Driver> AssignedDrivers { get; set; }        

    }
}
