using Core.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index(int page = 1)
        {
            var values = _categoryService.GetAll().ToPagedList(page, 3);
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = _categoryService.GetById(id);
            _categoryService.Delete(values);

            return RedirectToAction("Index");
        }
    }
}
