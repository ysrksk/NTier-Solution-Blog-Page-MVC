using Core.BusinessLayer.Abstract;
using Core.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        IWriterService _writerService;

        public HomeController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        public IActionResult Index()
        {

            return View("Home");
        }

        public IActionResult WriterList()
        {
            var result = _writerService.GetAllWriter();
            var jsonWriters = JsonConvert.SerializeObject(result);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult Add(Writer writer)
        {
            _writerService.AddWriter(writer);
            var jsonWriters = JsonConvert.SerializeObject(writer);
            return Json("Ok");
        }


    }
}
