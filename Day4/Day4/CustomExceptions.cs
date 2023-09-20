using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day4
{
    public class CustomException : Exception
    {
       public  CustomException() {
           
            //string message = "Error!";
            //Console.WriteLine(message);
       
        }

        public CustomException(string message) : base(message)
        {

        }

    }
    internal class CustomExceptions
    {
        public static void Main3()
        {
            try
            {
                int a = 1;
                int b = 0;
                if (b == 0)
                {
                    throw new CustomException();
                }
                else
                {
                    int c = a / b;
                    Console.WriteLine(c);

                }

            }
            catch(CustomException e)
            {
               Console.WriteLine("Hello!" + e.ToString());

            }
        }
    }
}
