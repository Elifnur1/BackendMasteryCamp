using System;

namespace EShop.Shared.DTOS.ResponseDtos;

//Bu sınıf içinde;
//1- Geri döndürülecek datayı 
//2- Geri döndürülecek hata mesajını
//3- Geri döndürülecek hata kodunu
//4- Geri döndürülecek işlemin başarılı olup olmadığını 
//tutacağız.
public class ResponseDto<T>
{
    public T? Data { get; set; }  //dönücek data propu
    public string? Error { get; set; } //dönücek hata mesajı propu
    public int StatusCode { get; set; }  //dönücek hata kodu propu
    public bool IsSuccessful { get; set; }  //dönücek işlemin başarı durumunu belirten propdur.


    // Başarılı durumlarda kullanılacak method
    public static ResponseDto<T> Success(T? data, int StatusCode)
    {
        return new ResponseDto<T>
        {
            Data = data,
            StatusCode = StatusCode,
            IsSuccessful = true
        };

    }

    //Başarılı ama geriye data döndürülmeyecek durumlarda kullanılacak metot

    public static ResponseDto<T> Success(int StatusCode)
    {
        return new ResponseDto<T>
        {
            Data = default,
            StatusCode = StatusCode,
            IsSuccessful = true
        };
    }
    //Hata durumunda kullanılacak metot
    public static ResponseDto<T> Fail(string error, int statusCode)
    {
        return new ResponseDto<T>
        {
            Error = error,
            StatusCode = statusCode,
            IsSuccessful = true
        };
    }
}
