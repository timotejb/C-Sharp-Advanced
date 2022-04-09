using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.OOP.Class3.App.Utils
{
    public static class StringUtils
    {
        public static string CapitaliseFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            char firstLetter = text[0];
            string capitalisedLetter = firstLetter.ToString().ToUpper();
            if(text.Length == 1)
            {
                return capitalisedLetter;
            }
            return $"{capitalisedLetter}{text.Substring(1)}";
        }
    }
}
