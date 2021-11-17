using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AbstractSite.ViewModels;

namespace AbstractSite.Controllers
{
    [Route("[controller]")]
    public class NotificationController : Controller
    {
        private readonly ILogger<NotificationController> _logger;

        public NotificationController(ILogger<NotificationController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var modelEngine = new ReviewNotification(Enums.NotificationState.NEW);
            var model = modelEngine.Finalize();
            return View(model);
        }

        [HttpPost]  // This is a POST request
        public IActionResult Submit(object model)
        {
            _logger.LogInformation("Notification submitted");
            return RedirectToAction("Index");
        }

    }
}
