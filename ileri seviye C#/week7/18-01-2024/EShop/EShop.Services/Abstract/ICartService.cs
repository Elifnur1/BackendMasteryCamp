using System;
using Azure;
using EShop.Shared.Dtos;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services.Abstract;

public interface ICartService
{
    Task<ResponseDto<CartDto>> GetByIdAsync();
    Task<ResponseDto<IEnumerable<CartDto>>> GetAllAsync();

}
