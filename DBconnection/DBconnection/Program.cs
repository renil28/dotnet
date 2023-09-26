using DBconnection.Models;


namespace DBconnection
{
    //Performing CRUD with connection to database SQL
    internal class Program
    {
        //View Data
        public static void GetValuefromDB(BookDbContext db)
        {
            var books = db.Books;
            foreach (var item in books)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Bookname);
            }
        }

        //Add Data
        public static void AddDatatoDB(BookDbContext db)
        {
            Console.WriteLine("Please enter some book name: ");
            Book book = new Book();
            book.Bookname = Console.ReadLine();
            db.Add(book);
            db.SaveChanges();
        }
        //Update Data
        public static void UpdateDataInDB(BookDbContext db)
        {
            Console.WriteLine("Enter Book ID which you want to update");
            GetValuefromDB(db);
            int ID = Convert.ToInt32(Console.ReadLine());
            var book = db.Books.Where(x => x.Id == ID).FirstOrDefault();
            Console.WriteLine("enter book name which you want to update: ");
            string bookName = Console.ReadLine();
            book.Bookname = bookName;
            db.Books.Update(book);
            db.SaveChanges();
        }
        //Delete Data
        public static void DeleteDataInDB(BookDbContext db)
        {
            Console.WriteLine("Enter Book ID which you want to delete");
            GetValuefromDB(db);
            int ID = Convert.ToInt32(Console.ReadLine());
            var book = db.Books.Where(x => x.Id == ID).FirstOrDefault();
            db.Books.Remove(book);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            BookDbContext db = new BookDbContext();
            //AddDatatoDB(db);
            //GetValuefromDB(db);
            //UpdateDataInDB(db);
            //DeleteDataInDB(db);


        }
    }
}