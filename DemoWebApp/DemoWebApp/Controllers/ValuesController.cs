using DemoWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        BookDbContext db = new BookDbContext();
        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return db.Books;
        }
        [HttpPost]
        public IActionResult PostBooks(Book book)
        {
            db.Books.Add(book); 
            db.SaveChanges();
            return  Ok("Record is being added successfully");

        }
    }
}
