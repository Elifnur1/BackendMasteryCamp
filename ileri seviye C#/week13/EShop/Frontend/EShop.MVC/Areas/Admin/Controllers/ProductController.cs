using EShop.MVC.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace EShop.MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IToastNotification _toastNotification;
        public ProductController(IProductService productService, ICategoryService categoryService, IToastNotification toastNotification)
        {
            _productService = productService;
            _categoryService = categoryService;
            _toastNotification = toastNotification;
        }
        [NonAction]
        private async Task<List<SelectListItem>> GenerateCategoryList()
        {
            var categories = (await _categoryService.GetAllActivesAsync()).Data;
            List<SelectListItem> categoryList = categories!.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()
            }).ToList();
            return categoryList;

        }
        public async Task<ActionResult> Index()
        {
            var response = await _productService.GetAllAsync();
            return View(response.Data);//Bilerek hata kontrolü yapmadık , aslında doğru olan yapmak.
        }

    }
}
