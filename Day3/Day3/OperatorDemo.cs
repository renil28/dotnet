using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //Sum and Subtraction of 2 objects
    //<access-specifier> <classname> operator <operator-name> (parameters)
    
    class subtract
    {
        public int Number;
        
        public subtract(int Number)
        {
            this.Number = Number;

        }
        public static subtract operator -(subtract s1, subtract s2) { 
            subtract s3 = new subtract(0);
            s3.Number = s1.Number - s2.Number;
            return s3;
        }

        public void print()
        {
          Console.WriteLine("The Number after Subtraction is:" + Number);
        }

    }
    
    class sum
    {
        public int Number;
        public sum(int Number) {
            this.Number = Number;

        }

        //Overloading + operator
        public static sum operator +(sum s1, sum s2)
        {
            sum s3 = new sum(0);
            s3.Number = s1.Number + s2.Number;
            return s3;
        }

        public void print()
        {
            Console.WriteLine("Number Value is: " + Number);
        }

    }
    internal class OperatorDemo
    {
        static void Main2(string[] args)
        {
            //For Sum
            sum s1 = new sum(1);
            sum s2 = new sum(1);
            sum s3 = new sum(0);
            s3 = s1 + s2;
            s3.print();
            Console.WriteLine();

            //For Subtraction
            subtract s4 = new subtract(5);
            subtract s5 = new subtract(3);
            subtract s6 = new subtract(0);
            s6 = s4 - s5;
            s6.print();
            Console.WriteLine() ;
        }
    }
}
