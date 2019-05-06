using Microsoft.AspNetCore.Mvc;

namespace Star.Web.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
