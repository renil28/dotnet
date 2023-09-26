using DBconnection.Models;


namespace DBconnection
{
    internal class Program
    {
        public static void GetValuefromDB(BookDbContext db)
        {
            var books = db.Books;
            foreach (var item in books)
            {
                Console.WriteLine(item.Bookname);
            }
        }

        public static void AddDatatoDB(BookDbContext db)
        {
            Console.WriteLine("Please enter some book name: ");
            Book book = new Book();
            book.Bookname = Console.ReadLine();
            db.Add(book);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            BookDbContext db = new BookDbContext();
            AddDatatoDB(db);
            GetValuefromDB(db);
        }
    }
}