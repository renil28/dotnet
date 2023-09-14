using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Day1New
{
    internal class Functiondemo
    {
        static void Sum(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }
        static void Divide(int a, int b)
        {
            Console.WriteLine("Division: " + (a / b));

        }
        static void Sub(int a, int b)
        {
            Console.WriteLine("Sub: " + (a - b));

        }
        static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));

        }
        //Swapping Numbers
        public static void Swap(ref int a, ref int b)
        {
            int c;
            c = b;
            b = a;
            a = c;
            Console.WriteLine("a" + a + ", b =" + b);
        }
        
        public static void Out(out int a)
        {
            a = 20;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Calculator");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Swap/Out");
                Console.WriteLine("Press 0 to exit");
                Console.WriteLine("Enter your Choice:");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if(Choice == 0)
                {
                    break;
                }


                Console.WriteLine("Please Enter a Value for Number 1:");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Value for Number 2:");
                int Number2 = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Sum(Number1, Number2);
                        break;
                    case 2: 
                        Sub(Number1,Number2); 
                        break;
                    case 3:
                        Mul(Number1, Number2);
                        break;
                    case 4:
                        Divide(Number1, Number2);
                        break;
                    case 5:
                        Out(out Number1);
                        Swap(ref Number1,ref  Number2);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }
            } while (true);


        }

    }
}
