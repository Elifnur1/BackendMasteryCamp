using System;
using EShop.Shared.DTOS.ResponseDtos;

namespace EShop.Service.Abstract;

public interface IAuthService
{
    Task<ResponseDto> LoginAsync(LoginDto loginDto)
}
