using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.Dtos.Auth;

public class ResetPasswordDto
{
    public string? Token { get; set; }
    [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
    [EmailAddress(ErrorMessage = "Geçerli mail girin")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Şifre alanı boş bırakılamaz.")]

    public string? Password { get; set; }
    [Required(ErrorMessage = "Email alanı boş bırakılamaz.")]
    [Compare("Password", ErrorMessage = "Şifre uyuşmuyor")]
    public string? ConfirmPassword { get; set; }
}
