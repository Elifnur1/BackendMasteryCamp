using System;
using System.Net;
using System.Net.Mail;
using EShop.Shared.Configurations.Email;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

namespace EShop.Services.Concrete;

public class EmailManager : IEmailService
{
    private readonly EmailConfig _emailConfig;

    public EmailManager(IOptions<EmailConfig> emailConfig) //IOptions kullanarak appsettings.json dosyasındaki EmailConfig sınıfındaki değerleri alıyoruz.
    {
        _emailConfig = emailConfig.Value;
    }

    public async Task<ResponseDto<NoContent>> SendEmailAsync(string emailTo, string subject, string htmlBody)
    {
        try
        {
            if (string.IsNullOrEmpty(_emailConfig.SmtpServer))
            {
                return ResponseDto<NoContent>.Fail("SMTP sunucu adresi yapılandırılmamıştır.", StatusCodes.Status500InternalServerError);
            }
            if (string.IsNullOrEmpty(_emailConfig.SmtpPassword))
            {
                return ResponseDto<NoContent>.Fail("SMTP şifresi yapılandırılmamıştır.", StatusCodes.Status500InternalServerError);
            }
            if (string.IsNullOrEmpty(emailTo))
            {
                return ResponseDto<NoContent>.Fail("Alıcı email adresi boş olamaz", StatusCodes.Status400BadRequest);
            }
            if (!IsValidEmail(emailTo))
            {
                return ResponseDto<NoContent>.Fail("Geçersiz email adresi", StatusCodes.Status400BadRequest);
            }
            //mail gönderme operasyonu
            using var smtpClient = new SmtpClient(_emailConfig.SmtpServer, _emailConfig.SmtpPort)
            {
                Credentials = new NetworkCredential(_emailConfig.SmtpUser, _emailConfig.SmtpPassword),
                EnableSsl = true,
                Timeout = 10000 //10 saniye içinde mail gönderilmezse timeout olacak
            };
            var mailMessage = new MailMessage //MailMessage sınıfı ile mail gönderme işlemlerini yapacağız.
            {
                From = new MailAddress(_emailConfig.SmtpUser),
                Subject = subject,
                Body = htmlBody,
                IsBodyHtml = true, //Bu mailin html formatında olduğunu belirtir.Yazmasak da varsayılan değeri true'dur.
                To = { new MailAddress(emailTo) }
            };
            await smtpClient.SendMailAsync(mailMessage); //Mail gönderme işlemi gerçekleşir.
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);


        }
        catch (SmtpException)
        {

            return ResponseDto<NoContent>.Fail("Mail gönderilirken bir hata oluştu", StatusCodes.Status502BadGateway);
        }
        catch (Exception ex)
        {
            return ResponseDto<NoContent>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }

    private bool IsValidEmail(string emailAdress)
    {
        try
        {
            var addr = new MailAddress(emailAdress);
            return addr.Address == emailAdress; //bu satırda email adresi doğru formatta mı kontrol ediliyor.
        }
        catch (Exception)
        {
            return false;
        }
    }
}
