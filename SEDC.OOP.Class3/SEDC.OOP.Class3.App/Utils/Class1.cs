using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.Class3.App
{
    public static class Class1
    {
        public static int Counter { get; set; }

        static Class1()
        {
            Counter = 1;
        }
        public static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
  
}
