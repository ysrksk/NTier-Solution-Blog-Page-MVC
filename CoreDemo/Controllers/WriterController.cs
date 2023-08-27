using Core.BusinessLayer.Abstract;
using Core.BusinessLayer.VallidationRules;
using Core.Entity.Concrete;
using CoreDemo.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [Authorize]
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.v = userMail;
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var result = _writerService.GetWriterById(1);
            return View(result);
        }


        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            var validator = new WriterValidator();
            ValidationResult validationResult = validator.Validate(writer);
            if (validationResult.IsValid)
            {
                _writerService.UpdateWriter(writer);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }

        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage writer)
        {
            Writer model = new Writer();

            if (writer.WriterImage != null)
            {
                var extension = Path.GetExtension(writer.WriterImage.FileName);
                var newImageName = Guid.NewGuid().ToString() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                writer.WriterImage.CopyTo(stream);
                model.WriterImage = newImageName;
            }

            model.WriterStatus = true;
            model.WriterMail = writer.WriterMail;
            model.WriterPassword = writer.WriterPassword;
            model.WriterName = writer.WriterName;
            model.WriterAbout = writer.WriterAbout;

            _writerService.AddWriter(model);
            return RedirectToAction("BlogListByWriter", "Blog");
        }
    }
}
