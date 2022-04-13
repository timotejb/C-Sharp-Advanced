using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics.Enteties
{
    public class GenericMethods
    {
        public void PrintObject<T>(T objectToPrint)
        {
            Console.WriteLine(objectToPrint);
        }
    }
}
