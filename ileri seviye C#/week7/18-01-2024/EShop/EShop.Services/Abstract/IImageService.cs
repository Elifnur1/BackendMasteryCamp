using System;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;

namespace EShop.Services.Abstract;

public interface IImageService
{
    Task<ResponseDto<string>> UploadImageAsync(IFormFile image); //Dosya formatında image yükleme(resim) operasyonu imza metotu.    
    ResponseDto<NoContent> DeleteImage(string imageUrl); //Yüklenmiş resimi silme operasyonu,silme işleminde geri dönüş tipi olmaz bu nedenle NoContent.

}
