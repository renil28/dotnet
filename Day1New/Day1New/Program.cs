namespace Day1New
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Please Enter a Value for Number 1:");
            int Number1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please Enter a Value for Number 2:");
            int Number2 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Please Enter a Value for Number 3");
            int Number3 = Convert.ToInt32(Console.ReadLine());

            /* Math Operations
            Console.WriteLine(Number1 + Number2);
            Console.WriteLine(Number1 * Number2);
            Console.WriteLine(Number1 / Number2);
            Console.WriteLine(Number2 - Number1);
            Console.WriteLine("Modulus: "+( Number1 % Number2));
            Console.WriteLine("The Entered Value: " + (Number3));
            */

            //Checking Greater than, less than
            if (Number1 > Number2)
            {
                Console.WriteLine(Number1 + "is greater than " + Number2);
            }
            else
            {
                Console.WriteLine(Number2 + " is greater than " + Number1);
            }

            //Check Odd/Even Number
            if(Number3%2 == 0)
            {
                Console.WriteLine(Number3 + " is an even number");
            }
            else
            {
                Console.WriteLine(Number3 + " is an odd number");
            }

            //Check greater than with ternary operator
            string output = (Number1 > Number2) ? (Number1 + " is greater than " + Number2) : (Number2 + " is greater than " + Number1);
            Console.WriteLine(output);
           
            //Check the greatest number from 3 numbers
            if(Number1>Number2 && Number1 > Number3)
            {
                Console.WriteLine(Number1 + " is the greatest number from given 3 numbers");
            }
            else if (Number2 > Number1 && Number2 > Number3)
            {
                Console.WriteLine(Number2 + " is the greatest number from given 3 numbers");
            }
            else
            {
                Console.WriteLine(Number3 + " is the greatest number from given 3 numbers");
            }


        }
    }
}