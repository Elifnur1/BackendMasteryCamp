using Microsoft.AspNetCore.Mvc;
using Project07_MVCTemelleri.Models;

namespace Project07_MVCTemelleri.Controllers
{
    public class MVC03DataTransferController : Controller
    {
        public ActionResult Index()
        {
            string name="Elif";
            ViewBag.WelcomeMessage=$"Hoşgeldin {name}";


            List<Category> categorylist=[
                new Category{Id=1,Name="Telefon", Description="Telefon kategorisi"},
                new Category{Id=2,Name="Bilgisayar", Description="Bilgisayar kategorisi"},
                new Category{Id=3,Name="Kitap", Description="Kitap kategorisi"}
            ];
            ViewBag.categorylist=categorylist;
            ViewData["categorylist"]=categorylist;
            return View();

        }

    }
}
