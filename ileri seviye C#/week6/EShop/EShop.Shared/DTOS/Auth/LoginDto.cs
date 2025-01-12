using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.DTOS.ResponseDtos;

public class LoginDto
{
    [Required(ErrorMessage ="Ad alanı boş bırakılamaz")]
    public string? UserName { get; set; }
    [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]

    public string? Pasword { get; set; }
}
