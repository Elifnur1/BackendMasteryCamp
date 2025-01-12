using System;

namespace EShop.Shared.DTOS.Auth;

public class TokenDto
{
    public string? AccessToken { get; set; }
    public DateTime AccessTokenExpirationDate { get; set; }
}
