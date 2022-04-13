using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.OOP.Class4.Extensions.Extensions
{
    public static class StringExtensions
    {
        public static string DeleteLastCharacter(this string text)
        {
            return text.Substring(0, text.Length-1);
        }

        public static string AddQuotations(this string text)
        {
            return $@"""{text}""";
        }
    }
}
