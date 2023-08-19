using Core.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        IWriterService _writerService;

        public WriterMessageNotification(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    }
}
