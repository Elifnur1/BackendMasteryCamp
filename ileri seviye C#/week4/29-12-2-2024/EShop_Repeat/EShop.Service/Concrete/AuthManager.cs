using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Azure.Core;
using EShop.Entity.Concrete;
using EShop.Service.Abstract;
using EShop.Shared.Configurations.Auth;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.Auth;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


namespace EShop.Service.Concrete;

public class AuthManager : IAuthService
{
    private readonly UserManager<ApplicationUser> _useManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private JwtConfig _jwtConfig;

    public AuthManager (UserManager<ApplicationUser> useManager, SignInManager<ApplicationUser> signInManager,IOptions<JwtConfig> options)
    {
        _useManager = useManager;
        _signInManager = signInManager;
        _jwtConfig = options.Value;
    }
    

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