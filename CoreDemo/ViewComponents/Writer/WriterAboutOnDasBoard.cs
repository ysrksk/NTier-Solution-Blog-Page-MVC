using Core.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDasBoard : ViewComponent
    {
        IWriterService _writerService;

        public WriterAboutOnDasBoard(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            var lastUser = _writerService.GetAllWriter(x => x.WriterMail == User.Identity.Name && x.WriterStatus == true).Select(y => y.WriterID).FirstOrDefault();
            var user = _writerService.GetWriterById(lastUser);
            return View(user);
        }
    }
}

