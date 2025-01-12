using System;
using System.ComponentModel.DataAnnotations;

namespace EShop.Shared.DTOS.Auth;

public class ChangePasswordDto
{
    [Required(ErrorMessage = "Ad alanı boş bırakılamaz")]
    public string? UserName { get; set; }
    [Required(ErrorMessage = "Mevcut şifre alanı boş bırakılamaz")]
    public string? CurrentPassword { get; set; }
    [Required(ErrorMessage = "Yeni şifre alanı boş bırakılamaz")]

    public string? NewPassword { get; set; }
    public int MyProperty { get; set; }
}
