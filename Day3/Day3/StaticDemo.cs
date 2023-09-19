using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //This program demonstrates how to use static in class, functions
    //and variables.
    static class StaticDemoClass
    {
        public static int a;
        //public int c;
    }

    class StaticDemoClass2
    {
        //Static will be called first
        static StaticDemoClass2()
        {
            Console.WriteLine("Hi, I am a static constructor");
        }
        public StaticDemoClass2()
        {
            Console.WriteLine("Hi, I am a default constructor");
        }
        public StaticDemoClass2(int a)
        {
            Console.WriteLine("Hi, I am a parameterised constructor");
        }
    }
    class D
    {
        private D()
        {

        }
        public static D getInstance()
        {
            return new D();
        }
    }
    internal class StaticDemo
    {
        public static void Main()
        {
            StaticDemoClass.a = 1;
            StaticDemoClass2 b = new StaticDemoClass2 ();
            StaticDemoClass2 c = new StaticDemoClass2(3);
            D.getInstance();
        }
    }
}
