using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.MVC.Areas.Admin.Models
{
    public class CategoryCreateModel
    {
        [Display(Name = "Kategori")] //Display attribute'ü ile label kısmındaki yazıyı değiştirmiş olduk.
        [Required(ErrorMessage = "Kategori adı zorunludur.")]
        [StringLength(100, ErrorMessage = "Kategori adı en fazla 100 karakter olmalıdır.")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Kategori Açıklaması")]
        [StringLength(300, ErrorMessage = "Kategori açıklaması en fazla 300 karakter olmalıdır.")]
        public string? Description { get; set; }

        [Display(Name = "Kategori Görseli")]
        public IFormFile? Image { get; set; }
    }
}
