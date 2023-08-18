using Core.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        INewsLetterService _newLetterService;
        public NewsLetterController(INewsLetterService newsLetterService)
        {
            _newLetterService = newsLetterService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
