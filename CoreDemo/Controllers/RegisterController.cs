
using Core.BusinessLayer.Abstract;
using Core.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		private readonly IWriterService _writerService;

		public RegisterController(IWriterService writerService)
		{
			_writerService = writerService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Writer writer)
		{
			writer.WriterStatus = true;
			writer.WriterAbout = "Deneme";
			_writerService.AddWriter(writer);
			return RedirectToAction("Index", "Blog");
		}
	}
}
