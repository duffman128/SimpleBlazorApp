using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolBlazorApp.Shared.pipes //Is called extensions instead of pipes
{
    public static class StringExtensions
    {
        public static string ReverseString(this string str)
        {
            string outputValue = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                char c = str[i];
                outputValue += c;
            }

            return outputValue;
        }

        public static string TitleCase(this string str)
        {
            return str[0].ToString().ToUpper() + str.Substring(1).ToLower();
        }
    }
}
