using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics.Enteties
{
    public class Order : BaseEntity
    {
        public Product Product { get; set; } 
        public string Address { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine(Product + " - " + Address);
        }
        public override string ToString()
        {
            return Product + " - " + Address;
        }
    }
}
