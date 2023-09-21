using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    //This program demonstrates the use of anonymous and delegate
    internal class Anonymous
    {
        // <access modifier> delegate <return> method(Parameters)
        // signature to a delegate
        public delegate void addNumber(int a, int b);

        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum: " + (a + b));
        }

        public void Subtract(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Subtraction: " + (a - b));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        public void Division(int a, int b)
        {
            if(b == 0)
            {
                Console.WriteLine("Can't divide");
            }
            else
            {
                Console.WriteLine("Division: " + (a / b));
            }
            
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication: " + a * b);
        }

        public static void Main()
        {
            
            Console.WriteLine("Calculator");
            //Anonymous
            //var employee = new { studentID = 101, name = "Renil" };
            //Console.WriteLine(employee.studentID);

            Anonymous cl = new Anonymous();
            
            do
            {
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("Press 0 to exit");
                Console.WriteLine("Enter your Choice:");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if (Choice == 0)
                {
                    break;
                }

                //Input the values
                Console.WriteLine("Please Enter a Value for Number 1:");
                int Number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Value for Number 2:");
                int Number2 = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        //invoking delegate to perform the operation
                        addNumber obj = new addNumber(cl.Sum);
                        obj(Number1, Number2);
                        break;
                    
                    case 2:
                        //invoking delegate to perform the operation
                        addNumber obj3 = new addNumber(cl.Subtract);
                        obj3(Number1, Number2);

                        break;
                    
                    case 3:
                        //invoking delegate to perform the operation
                        addNumber obj2 = new addNumber(cl.Multiply);
                        obj2(Number1, Number2);
                        break;
                    
                    case 4:
                        //invoking delegate to perform the operation
                        addNumber obj4 = new addNumber(cl.Division);
                        obj4(Number1, Number2);
                        break;
                   
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }
            } while (true);

        }

    }
}
