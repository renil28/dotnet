using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    //Implementation of Partial Class
    partial class Part1
    {
        public void Print1()
        {
            Console.WriteLine("Hi, I am from Part1");
        }
    }
    partial class Part1 { 
        public void Print2() { 
            Console.WriteLine("Hi I amd from Part2");
        }
    }
    //This program demonstrates the use of Lambda and Linq 
    internal class Lambda
    {
        public static void Main2()
        {
            //Using lambda to find odd/even numbers from a list
            List<int> Numbers = new List<int>() { 1,2,3,4,5,6};
            List<int> evenNumbers = Numbers.FindAll(x => (x%2) == 0);
            Console.WriteLine("Even Numbers: ");
            foreach (int number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            List<int> oddNumbers = Numbers.FindAll(x => (x % 2) != 0);
            Console.WriteLine("Odd Numbers: ");
            foreach (int number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
