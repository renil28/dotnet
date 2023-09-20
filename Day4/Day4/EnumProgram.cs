using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    //This Program Demonstrates Enum
    enum Status
    {
        Active = 1,
        Deactivate =2 ,
        Hold=3
    }
    enum Week
    {
        Monday = 1, 
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6, 
        Sunday = 7
    }
    internal class EnumProgram
    {
        public static void Main2()
        {
            //Console.WriteLine((int)Status.Active);
            Console.WriteLine("Write which day to be shipped(1-7)");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Status of the Delivery(1-3)");
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Delivery Status: ");
            switch ((Status)input2)
            {
                case Status.Active:
                    Console.WriteLine(Status.Active);
                    break;
                case Status.Hold: 
                    Console.WriteLine(Status.Hold);
                    break;
                case Status.Deactivate:
                    Console.WriteLine(Status.Deactivate);
                    break;
                default:
                    break;
            }

            Console.WriteLine("Expected Delivery Day: ");
            switch ((Week)input)
            {
                case Week.Monday:
                    Console.WriteLine(Week.Monday);
                    break;
                case Week.Tuesday: 
                    Console.WriteLine(Week.Tuesday);
                    break;
                case Week.Wednesday:    
                    Console.WriteLine(Week.Wednesday);  
                    break;
                case Week.Thursday:
                    Console.WriteLine(Week.Thursday);
                    break;
                case Week.Friday:
                    Console.WriteLine(Week.Friday);
                    break;
                case Week.Saturday:
                    Console.WriteLine(Week.Saturday);
                    break;
                case Week.Sunday:
                    Console.WriteLine(Week.Sunday);
                    break;
                default:
                    break;
            }
        }
    }
}
