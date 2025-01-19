using System;
using EShop.Services.Abstract;
using EShop.Shared.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;

namespace EShop.Services.Concrete;

public class ImageManager : IImageService
{
    private readonly string _imageFolderPath;
    public ImageManager()
    {
        _imageFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images");
        if (!Directory.Exists(_imageFolderPath))
        {
            Directory.CreateDirectory(_imageFolderPath);
        }
    }

    public ResponseDto<NoContent> DeleteImage(string imageUrl)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(imageUrl))
            {
                return ResponseDto<NoContent>.Fail("resim yolu boş olamaz", StatusCodes.Status400BadRequest);
            }
            var fileName = Path.GetFileName(imageUrl);
            var fileFullPath = Path.Combine(_imageFolderPath, fileName);
            if (!File.Exists(fileFullPath))
            {
                return ResponseDto<NoContent>.Fail("resim dosyası bulunamadı", StatusCodes.Status404NotFound)
                ;
            }
            File.Delete(fileFullPath);
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
        }
        catch (System.Exception ex)
        {

            return ResponseDto<NoContent>.Fail(ex.Message, StatusCodes.Status500InternalServerError);

        }
    }

    public async Task<ResponseDto<string>> UploadImageAsync(IFormFile image)
    {
        try
        {
            if (image == null)
            {
                return ResponseDto<string>.Fail("resim dosyası boş olamaz", StatusCodes.Status400BadRequest);
            }
            if (image.Length == 0)
            {
                return ResponseDto<string>.Fail("resim dosyası 0 byte'dan bütük olmalıdır", StatusCodes.Status400BadRequest);
            }
            var allowedExtensions = new[] { ".jpg", "jpeg", ".png", ".bmp", ".gif" };
            var imageExtension = Path.GetExtension(image.FileName);//.png
            if (!allowedExtensions.Contains(imageExtension))
            {
                return ResponseDto<string>.Fail("uygunsuz dosya uzantısı", StatusCodes.Status400BadRequest);
            }
            if (image.Length > 5 * 1024 * 1024)
            {
                return ResponseDto<string>.Fail("dosya uzantısı 5 MB den büyük olamaz", StatusCodes.Status400BadRequest);
            }
            var fileName = $"{Guid.NewGuid()}{imageExtension}";//rastgele bir dosya adı oluşturup yanına bizim istediklerimiz uzantılarda birini yazdı.ör:a3ahahdd-jfrwfrh4-ashdadjad454 gibi...

            var fileFullPath = Path.Combine(_imageFolderPath, fileName);
            using (var stream = new FileStream(fileFullPath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return ResponseDto<string>.Success($"/images/{fileName}", StatusCodes.Status201Created);
        }
        catch (System.Exception ex)
        {
            return ResponseDto<string>.Fail(ex.Message, StatusCodes.Status500InternalServerError);
        }
    }
}
