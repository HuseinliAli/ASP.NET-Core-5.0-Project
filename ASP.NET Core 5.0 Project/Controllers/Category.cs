using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_5._0_Project.Controllers
{
    public class Category : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());

        public IActionResult Index()
        {
            var values = categoryManager.GetAllCategories();
            return View(values);
        }
    }
}
