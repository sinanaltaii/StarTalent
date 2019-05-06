using Microsoft.AspNetCore.Mvc;

namespace Star.Web.Features.Home {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
