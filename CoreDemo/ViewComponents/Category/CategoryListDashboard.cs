using Core.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryListDashboard : ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryListDashboard(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _categoryService.GetAll();
            return View(result);
        }
    }
}

