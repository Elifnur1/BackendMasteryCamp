using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos.Auth;

public class ResetPasswordDto
{
    public string? Token { get; set; }

    [Required(ErrorMessage = "Burası boş bırakılamaz")]
    [EmailAddress(ErrorMessage = "geçerli adres girin")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Burası boş bırakılamaz")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Burası boş bırakılamaz")]
    [Compare("Password", ErrorMessage = "Şifre uyuşmuyor")]
    public string? ConfirmPassword { get; set; }
}
