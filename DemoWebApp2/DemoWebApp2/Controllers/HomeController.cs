using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using DemoWebApp2.Models;

namespace DemoWebApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //HttpClient client = new HttpClient();
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
