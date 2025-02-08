using System;
using EShop.Shared.Dtos.ResponseDtos;

namespace EShop.Services;

public interface IEmailService
{
    Task<ResponseDto<NoContent>>SendEmailAsync(string emailTo,string subject,string htmlBody);
}
