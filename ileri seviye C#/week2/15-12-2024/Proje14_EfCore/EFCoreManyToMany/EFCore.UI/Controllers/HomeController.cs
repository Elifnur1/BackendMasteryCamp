using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EFCore.UI.Models;

namespace EFCore.UI.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }


}
