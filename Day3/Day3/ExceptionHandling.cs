using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //This program demonstrates exception handling
    internal class ExceptionHandling
    {
        public static void Main8()
        {
            try
            {
                int a = 1;
                int b = 0;
                //int c = a / b; dividebyzero
                //int[] ar = new int[3]; arrayoutofbounds
                //Console.WriteLine(ar[4]);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("DivideByZero Exception Occured");
                //Console.WriteLine(e.ToString());
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("IndexOutOfRange Exception Occured");
            }
            catch (Exception e)
            {
                Console.WriteLine("Some ERROR Occured");
                //Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("I am in finally block");
            }


        }
        
    }
}
