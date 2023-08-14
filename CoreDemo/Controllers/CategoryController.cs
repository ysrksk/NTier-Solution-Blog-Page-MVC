using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {

            var values = cm.GetAllCategory();
            return View(values);
        }
    }
}
