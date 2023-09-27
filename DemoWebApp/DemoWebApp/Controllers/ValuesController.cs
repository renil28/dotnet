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
        public IEnumerable<Book> Index()
        {
            return db.Books;
        }
    }
}
