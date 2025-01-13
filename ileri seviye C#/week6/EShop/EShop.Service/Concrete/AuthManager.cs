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
    private readonly UserManager<ApplicationUser> _UserManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private JwtConfig _jwtConfig;
    //Aslında burada başka serviclerde olucak ,ancak henüz yazmadık.

    public AuthManager(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IOptions<JwtConfig> options)
    {
        _UserManager = userManager;
        _signInManager = signInManager;
        _jwtConfig = options.Value;
    }

    public Task<ResponseDto<NoContent>> ChangePasswordAsync(ChangePasswordDto changePasswordDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ForgetPasswordAsync(ForgotPasswordDto forgotPasswordDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<TokenDto>> LoginAsync(LoginDto loginDto)
    {
        try
        {
            var user = await _UserManager.FindByNameAsync(loginDto.UserName);
            if (user == null)
            {
                return ResponseDto<TokenDto>.Fail("Kullanıcı adı veya şifre hatalı", StatusCodes.Status400BadRequest);
            }
            var isValidPassword = await _UserManager.CheckPasswordAsync(user, loginDto.Pasword);
            if (!isValidPassword)
            {
                return ResponseDto<TokenDto>.Fail("Kullanıcı adı veya şifre hatalı", StatusCodes.Status400BadRequest);
            }
            var tokenDto = await GenerateJwtToken(user);
            return ResponseDto<TokenDto>.Success(tokenDto, StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Giriş yapılırken bir hata oluştu: {ex.Message}");
            throw;
        }
    }

    public Task<ResponseDto<ApplicationUserDto>> RegisterAsync(RegisterDto registerDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ResetPasswordAsync(ResetPasswordDto resetPasswordDto)
    {
        try
        {
            var existingUser = await _UserManager.FindByNameAsync(registerDto.UserName);
            if (existingUser != null)
            {
                return ResponseDto<ApplicationUserDto>.Fail("Bu kullanıcı adı zaten var.", StatusCodes.Status400BadRequest);
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
            var result = await _UserManager.CreateAsync(user, registerDto.Password);
            if (result.Succeeded)
            {
                return ResponseDto<ApplicationUserDto>.Fail("Kullanıcı oluşturulurken bir hata oluştu", StatusCodes.Status400BadRequest);
            }
            result = await _UserManager.AddToRoleAsync(user, registerDto.Role);
            if (!result.Succeeded)
            {
                return ResponseDto<ApplicationUserDto>.Fail("Kullanıcı rolü atanırken bir hata oluştu.", StatusCodes.Status400BadRequest);
            }
            var UserDto = new ApplicationUserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                Address = user.Address,
                City = user.City
            };
            return ResponseDto<ApplicationUserDto>.Success
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    private async Task<TokenDto> GenerateJwtToken(ApplicationUser user)
    {
        try
        {
            var roles = await _UserManager.GetRolesAsync(user);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier , user.Id),
                new Claim(ClaimTypes.Name , user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString())
            }.Union(roles.Select(x => new Claim(ClaimTypes.Role, x))); //Union ile tablo birleştirme yaptık.
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Secret));
            var credentialls = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToDouble(_jwtConfig.AccessTokenExpiration));

            var token = new JwtSecurityToken(
                issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                claims: claims,
                expires: expiry,
                signingCredentials: credentialls

            );
            var tokenDto = new TokenDto()
            {
                AccessToken = new JwtSecurityTokenHandler().WriteToken(token),
                AccessTokenExpirationDate = expiry
            };
            return tokenDto;

        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Token olluştururken bir hata oluştu: {ex.Message}");
            throw;
        }
    }
}
