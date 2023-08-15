using Core.BusinessLayer.Concrete;
using Core.DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager _blogManager = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var values = _blogManager.GetAllBlog();
            return View(values);
        }
    }
}
