using Core.BusinessLayer.Abstract;
using Core.Entity.Concrete;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        private readonly INewsLetterService _newsletterService;

        public BlogController(IBlogService blogService, ICommentService commentService, INewsLetterService newsletterService)
        {
            _blogService = blogService;
            _commentService = commentService;
            _newsletterService = newsletterService;
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
            var writerBlogs = _blogService.GetListWithWriter(result.WriterID);

            BlogViewModel vm = new BlogViewModel()
            {
                Blog = new Blog(),
                Blogs = new List<Blog>(),
                Comments = new List<Comment>(),
                NewsLetter = new NewsLetter(),
            };

            if (result != null)
                vm.Blog = result;

            if (comments != null)
                vm.Blogs = writerBlogs;

            if (comments != null)
                vm.Comments = comments;

            return View(vm);
        }

        [HttpPost]
        public IActionResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            _newsletterService.Add(newsLetter);
            return RedirectToAction("Blogs", "Blog");
        }
    }
}
