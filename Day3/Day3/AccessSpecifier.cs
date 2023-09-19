using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //This program demonstrates the role of access specifiers.
    //Refer excel sheet to know the differences between them!
    public class Sample
    {
        private protected int a;
    }
    public class Derived : Sample
    {
        //Console.WriteLine(a);
    }
    internal class AccessSpecifier
    {
        public static void Main5()
        {
            Day3.Demo1.Class1 x1 = new Day3.Demo1.Class1();
            Day3.Demo2.Class1 x2 = new Day3.Demo2.Class1();
            x1.show();
            x2.show();
            System.Console.WriteLine();
        }
    }
}
