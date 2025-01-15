using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos;

public class CartCreateDto
{
    [Required(ErrorMessage ="Bu alan zorunludur.")]
    public string? ApplicationUserId { get; set; }
}
