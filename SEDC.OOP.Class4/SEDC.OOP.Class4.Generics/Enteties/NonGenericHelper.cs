using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Generics.Enteties
{
    public class NonGenericHelper
    {
        public void GoThroughStringLIst (List<string> strings)
        {
            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
        }
        public void GetInfoForList(List<string> strings)
        {
            Console.WriteLine($"The list has {strings.Count} elements, and the elemtents are of tpye {strings.GetType()}");
        }
        public void GoThroughIntegerLIst(List<int> integers)
        {
            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }
        }
        public void GetInfoForIntegerList(List<int> integers)
        {
            Console.WriteLine($"The list has {integers.Count} elements, and the elemtents are of tpye {integers.GetType()}");
        }
    }
}