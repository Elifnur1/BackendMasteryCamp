using System;
using System.ComponentModel.DataAnnotations;
using EShop.Shared.ComplexTypes;

namespace EShop.Shared.DTOS.Auth;

public class RegisterDto
{
    [Required(ErrorMessage = "Ad alan boş bırakılamaz")]
    public string? FirstName { get; set; }
    [Required(ErrorMessage = "Soyad alan boş bırakılamaz")]
    public string? LastName { get; set; }

    [Required(ErrorMessage = "Adress alan boş bırakılamaz")]
    public string? Address { get; set; }
    [Required(ErrorMessage = "Cinsiyet alan boş bırakılamaz")]

    public GenderType Gender { get; set; }
    [Required(ErrorMessage = "Doğum tarihi alan boş bırakılamaz")]

    public DateTime DateOfBirth { get; set; }
    [Required(ErrorMessage = "Adress alan boş bırakılamaz")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Kullanıcı adı alan boş bırakılamaz")]
    [EmailAddress(ErrorMessage = "Geçerli mail girin")]
    public string? UserName { get; set; }
    [Required(ErrorMessage = "Şifre alan boş bırakılamaz")]

    public string? Pasword { get; set; }
    [Required(ErrorMessage = "Tekrar şifre alan boş bırakılamaz")]
    [Compare("Pas")]
    public string? ConfirmPassword { get; set; }
    [Required(ErrorMessage = "Rol  alan boş bırakılamaz")]

    public string? Role { get; set; } = "User";
}
