using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public virtual void PrintInfo()
        {
            Console.WriteLine(Id);
        }
 
    }
}
