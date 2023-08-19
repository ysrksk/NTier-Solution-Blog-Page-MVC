using Core.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.BlogLast3Post
{
    public class BlogListDashboard : ViewComponent
    {
        IBlogService _blogService;

        public BlogListDashboard(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _blogService.GetListWithCategory();
            return View(result);
        }
    }
}
