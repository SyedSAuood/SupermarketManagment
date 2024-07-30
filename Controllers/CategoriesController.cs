using Microsoft.AspNetCore.Mvc;
using SupermarketManagment.Models;

namespace SupermarketManagment.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {

            var category = CategoriesRepository.GetCategories();

            return View(category);
        }
        //asp.net is smart enought to map the query string or url with the action method
        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
            
            return View(category);

            //A method to show content of uRL
            // return new ContentResult { Content = id.ToString() };
        }
    }
}
