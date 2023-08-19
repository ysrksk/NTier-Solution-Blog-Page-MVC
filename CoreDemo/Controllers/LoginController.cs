using Core.BusinessLayer.Abstract;
using Core.Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDemo.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{

		IWriterService _writerService;

		public LoginController(IWriterService writerService)
		{
			_writerService = writerService;
		}

		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(Writer writer)
		{
			//var result = _writerService.GetAllWriter().FirstOrDefault(x => x.WriterMail == writer.WriterMail
			//&& x.WriterPassword == writer.WriterPassword);

			//if (result != null)
			//{
			//	HttpContext.Session.SetString("username", writer.WriterMail);
			//	return RedirectToAction("Index", "Writer");
			//}
			//else
			//{
			//	return View("Index", "Login");
			//}

			var result = _writerService.GetAllWriter().FirstOrDefault(x => x.WriterMail == writer.WriterMail
			&& x.WriterPassword == writer.WriterPassword);

			if (result != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, writer.WriterMail)
				};

				var userIdentity = new ClaimsIdentity(claims, "a");
				ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);
				await HttpContext.SignInAsync(claimsPrincipal);
				return RedirectToAction("Index", "Writer");
			}
			else
			{
				return View();
			}
		}
	}
}
