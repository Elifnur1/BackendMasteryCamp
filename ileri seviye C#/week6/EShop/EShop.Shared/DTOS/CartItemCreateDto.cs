using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.DTOS;

public class CartItemCreateDto
{
    [Required(ErrorMessage = "Sepet Id zorunludur.")]
    public int CartId { get; set; }

    [Required(ErrorMessage = "Ürün Id zorunludur.")]
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Ürün adedi zorunludur.")]
    public int Quantity { get; set; }
    

}
