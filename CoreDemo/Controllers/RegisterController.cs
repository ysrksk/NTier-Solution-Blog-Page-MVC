
using Core.BusinessLayer.Abstract;
using Core.BusinessLayer.VallidationRules;
using Core.Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class RegisterController : Controller
	{
		private readonly IWriterService _writerService;
		WriterValidator vm = new WriterValidator();

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
			ValidationResult result = vm.Validate(writer);
			if (result.IsValid)
			{
				writer.WriterStatus = true;
				writer.WriterAbout = "Deneme";
				_writerService.AddWriter(writer);
				return RedirectToAction("Index", "Blog");
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
	}
}
