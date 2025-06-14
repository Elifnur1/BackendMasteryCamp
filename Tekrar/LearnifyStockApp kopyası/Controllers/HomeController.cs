using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LearnifyStockApp.Models;

namespace LearnifyStockApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] // anlamı: bu sayfa her zaman yenilenecek ve önbelleğe alınmayacak.
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }); //RequestId, hata ayıklama için kullanılır.
    }
}
