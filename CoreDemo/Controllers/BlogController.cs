using Core.BusinessLayer.Abstract;
using Core.DataAccessLayer.Concrete.EntityFramework;
using Core.Entity.Concrete;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        EfAboutDal aboutDal = new EfAboutDal();

        public BlogController(IBlogService blogService, ICommentService commentService)
        {
            _blogService = blogService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _blogService.GetListWithCategory();
            _commentService.GetAllComment();
            return View(values);
        }

        public IActionResult BlogDetails(int blogId)
        {
            var result = _blogService.GetBlogById(blogId);
            var comments = _commentService.GetAll(blogId);



            BlogViewModel vm = new BlogViewModel()
            {
                Blog = new Blog(),
                Comments = new List<Comment>(),
            };

            if (result != null)
                vm.Blog = result;

            if (comments != null)
            {
                foreach (var item in comments)
                {
                    vm.Comments.Add(item);
                }
            }


            return View(vm);
        }
    }
}
