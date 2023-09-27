using DemoWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    [Route("api/[controller]")]
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
        public IActionResult PutBooks(Book book)
        {
            db.Books.Add(book); 
            db.SaveChanges();
            return  Ok("Record is being added successfully");

        }

        [HttpDelete]
        public IActionResult DeleteBooks(int id) { 
            var bk = db.Books.Where(x => x.Id == id).FirstOrDefault();
            db.Books.Remove(bk);
            db.SaveChanges();
            return Ok("Record has been deleted successfully");
        }
    }
}
