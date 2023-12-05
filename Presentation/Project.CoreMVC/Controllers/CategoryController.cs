using Microsoft.AspNetCore.Mvc;
using Project.Application.Managers;

namespace Project.CoreMVC.Controllers
{
    public class CategoryController : Controller
    {
       ICategoryManager _categoryManager;
        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
