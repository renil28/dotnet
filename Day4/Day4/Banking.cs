using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    struct Customer
    {
        public static int Id;
        public static string Name;
        public  static double Money;

        public void Register()
        {
            Console.WriteLine("Registration Portal");
            Console.WriteLine("--------------------");
            Console.WriteLine("Please Enter Desired Customer ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Customer Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter Minimum Balance");
            Money = Convert.ToDouble(Console.ReadLine());

        }
        public void AddMoney()
        {
            Console.WriteLine("Please Enter your ID:");
            int idd = Convert.ToInt32(Console.ReadLine());
            if (idd == Id)
            {
                Console.WriteLine("Banking ID: " + Id);
                Console.WriteLine("Customer Name: " + Name);
                Console.WriteLine("Please Enter the Money you want to Add: ");
                double AddMoney = Convert.ToDouble(Console.ReadLine());
                Money = Money + AddMoney;
                Console.WriteLine("Amount After Adding: " +  Money);
            }
            else
            {
                Console.WriteLine("The ID doesn't exist, please try again!");
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Please Enter your ID:");
            int idd = Convert.ToInt32(Console.ReadLine());
            if (idd == Id)
            {
                Console.WriteLine("Banking ID: " + Id);
                Console.WriteLine("Customer Name: " + Name);
                Console.WriteLine("Please Enter the Money you want to Add: ");
                double SubMoney = Convert.ToDouble(Console.ReadLine());
                if (SubMoney > Money)
                {
                    Console.WriteLine("Can't deduct money. Reason, low balance!");
                }
                else { 
                Money = Money - SubMoney;
                Console.WriteLine("Amount After Withdrawing: " + Money);
                }
            }
            else
            {
                Console.WriteLine("The ID doesn't exist, please try again!");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine("Please Enter your ID:");
            int idd = Convert.ToInt32(Console.ReadLine());
            if (idd == Id)
            {
                Console.WriteLine("Banking ID: " + Id);
                Console.WriteLine("Customer Name: " + Name);
                Console.WriteLine("Balance: " + Money);
                
            }
            else
            {
                Console.WriteLine("The ID doesn't exist, please try again!");
            }
        }

    }
    internal class Banking
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Banking Application");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Add Money");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("Enter your Choice:");
                int Choice = Convert.ToInt32(Console.ReadLine());


                Customer customer = new Customer();
                
               

                switch (Choice)
                {
                    
                    case 1:
                        customer.Register();
                        break;
                    case 2:
                        customer.AddMoney();
                        break;
                    case 3:
                        customer.Withdraw();
                        break;
                    case 4:
                        break;
                    case 5:
                        customer.CheckBalance();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }
            } while (true);
        }
    }
}
