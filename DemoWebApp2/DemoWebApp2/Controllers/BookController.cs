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
        public IActionResult RemoveBook(int id, Books books)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = client.DeleteAsync("https://localhost:7117/api/Values/?id=1");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
