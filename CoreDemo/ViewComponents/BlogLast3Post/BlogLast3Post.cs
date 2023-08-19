using Core.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.BlogLast3Post
{
    public class BlogLast3Post : ViewComponent
    {
        IBlogService _blogService;

        public BlogLast3Post(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _blogService.GetListLastThreePost();
            return View(result);
        }
    }
}
