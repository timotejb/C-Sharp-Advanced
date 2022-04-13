using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics.Enteties
{
    public class GenericHelper
    {
        public void GoThroughList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
        public void GetInfoForList <T>(List<T> list)
        {
            Console.WriteLine($"There are {list.Count} elements, they are of type {typeof(T)}");
        }
    }
}
