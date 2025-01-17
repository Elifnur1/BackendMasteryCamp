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

    public AuthManager(UserManager<ApplicationUser> useManager, SignInManager<ApplicationUser> signInManager, IOptions<JwtConfig> options)
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

    public async Task<ResponseDto<TokenDto>> LoginAsync(LoginDto loginDto)
    {
        try
        {
            var user = await _useManager.FindByNameAsync(loginDto.UserName);
            if (user == null)
            {
                return ResponseDto<TokenDto>.Fail("Kullanıcı adıveya şifre ahatalı", StatusCodes.Status400BadRequest);
            }
            var isValidPassword = await _useManager.CheckPasswordAsync(user, loginDto.Password);
            if (!isValidPassword)
            {
                return ResponseDto<TokenDto>.Fail("Kullanıcı adı veya şifre hatalı", StatusCodes.Status400BadRequest);
            }
            var tokenDto = await GenerateJwtToken(user);
            return ResponseDto<TokenDto>.Success(tokenDto, StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {

            System.Console.WriteLine($"giriş yapılırken bir hata oluştu: {ex.Message}");
        }
    }


    public async Task<ResponseDto<ApplicationUserDto>> RegisterAsync(RegisterDto registerDto)
    {
        try
        {
            var existingUser = await _useManager.FindByNameAsync(registerDto.UserName);
            if (existingUser != null)
            {
                return ResponseDto<ApplicationUserDto>.Fail("bu kullanıcı adı zaten kullanılmakta", StatusCodes.Status400BadRequest);
            }
            var user = new ApplicationUser(
                firstName: registerDto.FirstName,
                lastName: registerDto.LastName,
                dateOfBirth: registerDto.DateOfBirth,
                gender: registerDto.Gender

            )
            {
                UserName = registerDto.UserName,
                Email = registerDto.Email,
                EmailConfirmed = true,
                Address = registerDto.Address,
                City = registerDto.City
            };
            var result = await _useManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                return ResponseDto<ApplicationUserDto>.Fail("Kullanıcı oluşturulurken bir hata oluştu", StatusCodes.Status400BadRequest);
            }
            result = await _useManager.AddToRoleAsync(user, registerDto.Role);
            if (!result.Succeeded)
            {
                return ResponseDto<ApplicationUserDto>.Fail("kullanıcı rolü atanırken bir hata oluştu", StatusCodes.Status400BadRequest);
            }
            var userDto = new ApplicationUserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                City = user.City
            };
            return ResponseDto<ApplicationUserDto>.Success(userDto, StatusCodes.Status201Created);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Kayıt oluşurken bir hata oldu:{ex.Message}");
        }
    }

    public Task<ResponseDto<NoContent>> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
    {
        throw new NotImplementedException();
    }
}

internal class JwtConfig
{
}