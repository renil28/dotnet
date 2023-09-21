using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Customer
    {
        public int Id;
        public string Name;
        public double Money;

        public void Register(Customer c, string FilePath)
        {
            Console.WriteLine("Registration Portal");
            Console.WriteLine("--------------------");
            Console.WriteLine("Please Enter Desired Customer ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Customer Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please Enter Minimum Balance");
            Money = Convert.ToDouble(Console.ReadLine());
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine(JsonConvert.SerializeObject(c));
            sw.Flush();
            sw.Close();

        }
        public void AddMoney(Customer c, string FilePath)
        {
            Console.WriteLine("Please Enter your ID:");
            int idd = Convert.ToInt32(Console.ReadLine());
            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string output = sr.ReadLine();
            var x = JsonConvert.DeserializeObject<Customer>(output);
            sr.Close();
            if (idd == x.Id)
            {
                Console.WriteLine("Banking ID: " + x.Id);
                Console.WriteLine("Customer Name: " + x.Name);
                Console.WriteLine("Please Enter the Money you want to Add: ");
                double AddMoney = Convert.ToDouble(Console.ReadLine());
                x.Money = x.Money + AddMoney;
                Console.WriteLine("Amount After Adding: " + x.Money);

                Id = x.Id;
                Name = x.Name;
                Money = x.Money;
                
                StreamWriter sw = new StreamWriter(FilePath);
                sw.WriteLine(JsonConvert.SerializeObject(c));
                sw.Flush();
                sw.Close();
            }
            else
            {
                Console.WriteLine("The ID doesn't exist, please try again!");
            }
        }

        public void Withdraw(Customer c, string FilePath)
        {
            Console.WriteLine("Please Enter your ID:");
            int idd = Convert.ToInt32(Console.ReadLine());
            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string output = sr.ReadLine();
            var x = JsonConvert.DeserializeObject<Customer>(output);
            if (idd == x.Id)
            {
                Console.WriteLine("Banking ID: " + x.Id);
                Console.WriteLine("Customer Name: " + x.Name);
                Console.WriteLine("Please Enter the Money you want to Withdraw: ");
                double SubMoney = Convert.ToDouble(Console.ReadLine());
                if (SubMoney > x.Money)
                {
                    Console.WriteLine("Can't deduct money. Reason, low balance!");
                }
                else
                {
                    x.Money = x.Money - SubMoney;
                    Console.WriteLine("Amount After Withdrawing: " + x.Money);
                    Id = x.Id;
                    Name = x.Name;
                    Money = x.Money;

                    StreamWriter sw = new StreamWriter(FilePath);
                    sw.WriteLine(JsonConvert.SerializeObject(c));
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                Console.WriteLine("The ID doesn't exist, please try again!");
            }
        }

        public void CheckBalance(string FilePath)
        {
            Console.WriteLine("Please Enter your ID:");
            int idd = Convert.ToInt32(Console.ReadLine());
            StreamReader sr = new StreamReader(FilePath);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string output = sr.ReadLine();
            var x = JsonConvert.DeserializeObject<Customer>(output);

            if (idd == x.Id)
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Money);
            }
            else
            {
                Console.WriteLine("The ID doesn't exist, please try again!");
            }
        }

    }
    internal class Banking2
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

                string FilePath = "C:\\Users\\Administrator\\Desktop\\Dot Net Lab\\Day5\\Day5\\files\\test.txt";

                switch (Choice)
                {

                    case 1:
                        customer.Register(customer, FilePath);
                        break;
                    case 2:
                        customer.AddMoney(customer, FilePath);
                        break;
                    case 3:
                        customer.Withdraw(customer, FilePath);
                        break;
                    case 4:
                        break;
                    case 5:
                        customer.CheckBalance(FilePath);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }
            } while (true);
        }
    }
}