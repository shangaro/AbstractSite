using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AbstractSite.ViewModels;
using AbstractSite.Factories;

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
            INotification<BaseViewModel> notification = NotificationFactory.Create(Enums.NotificationState.VIEW,Enums.NotificationType.REVIEW);
            var model = notification.Finalize();
            return View(model);
        }
        [HttpGet("esr")]
        public IActionResult ESRForm()
        {
            INotification<BaseViewModel> notification = NotificationFactory.Create(Enums.NotificationState.VIEW, Enums.NotificationType.ESR);
            var model = notification.Finalize();
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
