using DemoWebApp2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DemoWebApp2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View("Delete");
        }


        public IActionResult AddBook(Books books)
        {
            using (HttpClient client = new HttpClient())
            {
                var request = new StringContent(JsonConvert.SerializeObject(books), System.Text.Encoding.UTF8, "application/json");

                var data = client.PostAsync("https://localhost:7117/api/Values", request).Result.Content.
                    ReadAsStringAsync().Result; 
            }
            return RedirectToAction("Index","Home");
        }
        public IActionResult RemoveBook(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                
            }
            return RedirectToAction("BookList", "Book");
        }

       

        public IActionResult BookList()
        {
            IEnumerable<Books> booklist = new List<Books>();
            using (HttpClient client = new HttpClient())
            {
                var data = client.GetAsync("https://localhost:7117/api/Values").Result.Content.
                    ReadAsStringAsync().Result;
                booklist = JsonConvert.DeserializeObject<IEnumerable<Books>>(data);
            }
            return View(booklist);
        }
    }
}
