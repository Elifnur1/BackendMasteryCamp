using Microsoft.AspNetCore.Mvc;

namespace EShop.MVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
