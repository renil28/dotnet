using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Menu
    { 
        public static void Main(string[] args)
        {
            string[] empname= new string[5];
            int[] salary = new int[5];
            int[] id = new int[5];
            void Add()
            {
                for (int i = 0; i < id.Length; i++)
                {
                    Console.WriteLine("Enter ID " + i);
                    id[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name " + i);
                    empname[i] = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary " + i);
                    salary[i] = Convert.ToInt32(Console.ReadLine());

                }

            }
            void Update()
            {
                Console.WriteLine("Enter the ID to change values");
                int idd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter New ID ");
                id[idd] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name ");
                empname[idd] = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary ");
                salary[idd] = Convert.ToInt32(Console.ReadLine());

            }
            void Delete()
            {
                Console.WriteLine("Enter the ID to delete values");
                int idd = Convert.ToInt32(Console.ReadLine());
                id = id.Where(val => val != idd).ToArray();

            }
            void Listt()
            {
                for (int j = 0; j < id.Length; j++)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine("ID:" + id[j]);
                    Console.WriteLine("Employee Name:" + empname[j]);
                    Console.WriteLine("Salary:" + salary[j]);
                    Console.WriteLine("----------------");
                }
            }

            do
            {
                Console.WriteLine("Employee");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. List");
                Console.WriteLine("Press 0 to exit");
                Console.WriteLine("Enter your Choice:");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if (Choice == 0)
                {
                    break;
                }

                Menu menu = new Menu();

                switch (Choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        Listt();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }
            } while (true);


        }
    }
}
