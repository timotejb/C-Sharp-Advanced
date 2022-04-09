using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties.Interfaces;

namespace Enteties
{
    public class Tester :ITester, IDeveloper
    {
        public void Code() //ja nasleduva od IDeveloper
        {
            Console.WriteLine("Writing automated tests");
        }
        public void TestCode() //ja nasleduva od ITester
        {
            Console.WriteLine("Testing the code!");
        }
    }
}