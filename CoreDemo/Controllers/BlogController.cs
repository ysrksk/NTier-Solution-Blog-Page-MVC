using Core.BusinessLayer.Abstract;
using Core.BusinessLayer.VallidationRules;
using Core.Entity.Concrete;
using CoreDemo.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICommentService _commentService;
        private readonly INewsLetterService _newsletterService;
        private readonly ICategoryService _categoryService;

        public BlogController(IBlogService blogService, ICommentService commentService, INewsLetterService newsletterService,
            ICategoryService categoryService)
        {
            _blogService = blogService;
            _commentService = commentService;
            _newsletterService = newsletterService;
            _categoryService = categoryService;
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

        [AllowAnonymous]
        public IActionResult BlogListByWriter()
        {
            var result = _blogService.GetListWithWriter(1);
            return View(result);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult BlogEkle()
        {
            List<SelectListItem> list = (from x in _categoryService.GetAll()
                                         select new SelectListItem
                                         {
                                             Text = x.CategoryName,
                                             Value = x.CategoryId.ToString(),
                                         }).ToList();
            ViewBag.cv = list;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult BlogEkle(Blog blog)
        {
            BlogValidator validationRules = new BlogValidator();
            ValidationResult result = validationRules.Validate(blog);
            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blog.WriterID = 1;
                _blogService.AddBlog(blog);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

                return View();
            }

        }

        public IActionResult Sil(int id)
        {
            var result = _blogService.GetBlogById(id);
            _blogService.DeleteBlog(result);
            return RedirectToAction("BlogListByWriter", "Blog");
        }
    }
}
