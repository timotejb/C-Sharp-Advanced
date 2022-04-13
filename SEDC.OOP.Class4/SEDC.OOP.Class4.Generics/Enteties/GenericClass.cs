using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics.Enteties
{
    public class GenericClass<T>
    {
        public T MyCostumProperty { get; set; }
        public GenericClass(T myProperty) { MyCostumProperty = myProperty; }
        public void PrintPropertyTypeAndValue()
        {
            Console.WriteLine($"The property type is {MyCostumProperty.GetType()} and the value is {MyCostumProperty}");
        }
    }
}
