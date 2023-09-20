using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//include this package for regex
using System.Text.RegularExpressions;

namespace Day4
{
    //This program demonstrates Regular Expressions and Pattern Matching
    internal class RegexDemo
    {
        public static void Main()
        {
            string pattern = "^[0-9]";
            Regex rg = new Regex(pattern);
            if(rg.IsMatch("323"))
            {
                Console.WriteLine("Pattern Matched");
            }
            else 
            {
                Console.WriteLine("Pattern Not Matched");
                   
             }
        }
    }
}
