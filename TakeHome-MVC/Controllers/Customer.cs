using Microsoft.AspNetCore.Mvc;

namespace TakeHome_MVC.Controllers
{
    public class Customer : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}