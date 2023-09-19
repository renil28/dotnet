using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class AccessSpecifier
    {
        public static void Main()
        {
            Day3.Demo1.Class1 x1 = new Day3.Demo1.Class1();
            Day3.Demo2.Class1 x2 = new Day3.Demo2.Class1();
            x1.show();
            x2.show();
            System.Console.WriteLine();
        }
    }
}
