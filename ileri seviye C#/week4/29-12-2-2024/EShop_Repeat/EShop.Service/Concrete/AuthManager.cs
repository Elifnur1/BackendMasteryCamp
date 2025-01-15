using EShop.Entity.Concrete;
using EShop.Service.Abstract;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.Auth;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Identity;

namespace EShop.Service.Concrete;

public class AuthManager : IAuthService
{
    private readonly UserManager<ApplicationUser> _useManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private JwtConfig _jwtConfig;
    public Task<ResponseDto<NoContent>> ChangePasswordAsync(ChangePasswordDto changePasswordDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<TokenDto>> LoginAsync(LoginDto loginDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<ApplicationUserDto>> RegisterAsync(RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
    {
        throw new NotImplementedException();
    }
}

internal class JwtConfig
{
}