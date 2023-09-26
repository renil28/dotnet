namespace BankingSQL
{
    internal class Program
    {

        public static void CheckBalance(BankDBContext db)
        {
            Console.WriteLine("Please Enter your ID:");
            int idd = Convert.ToInt32(Console.ReadLine());
            var balance = db.Bank;
            foreach (var item in balance)
            {
                if (idd == item.Id)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.Money);
                }
                else
                {
                    Console.WriteLine("The ID doesn't exist, please try again!");
                }
            }
        }

        public static void Register(BankDBContext db)
        {
            Console.WriteLine("Please Enter Name: ");
            Bank b = new Bank();
            b.Name = Console.ReadLine();
            Console.WriteLine("Please Enter Minimum Balance");
            b.Money = Convert.ToDouble(Console.ReadLine());
            db.Add(b);
            db.SaveChanges();

        }

        static void Main(string[] args)
        {
            BankDBContext db = new BankDBContext();
            Register(db);
            CheckBalance(db);
        }
    }
}