using Microsoft.AspNetCore.Mvc;

namespace SupermarketManagment.Controllers
{
    public class HomeController : Controller
    {
        public  IActionResult Index()
        {
            return View();
        }
    }
}
