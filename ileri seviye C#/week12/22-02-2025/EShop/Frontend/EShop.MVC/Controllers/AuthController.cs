using EShop.MVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace EShop.MVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;
        private readonly ToastNotification _toastNotification;

        public AuthController(IAuthService authService, NToastNotify.ToastNotification toastNotification)
        {
            _authService = authService;
            _toastNotification = toastNotification;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(string? returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

    }


}
