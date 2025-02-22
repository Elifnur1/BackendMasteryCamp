using System;

namespace EShop.MVC.Services.Interfaces;

public interface IHttpClientService
{
    Task<TResponse?> GetAsync<TResponse>(string endpoint);
    Task<TResponse?>PostAsync<TRequest , TResponse>(string endpoint, TRequest request);
    Task<TResponse?>PostFromAsync<TResponse>(string endpoint, MultipartFormDataContent formData);
    Task<TResponse?>PutAsync<TResponse>(string endpoint, MultipartFormDataContent formData);
    Task<TResponse?>PutFromAsync<TResponse>(string endpoint, MultipartFormDataContent formData);
    Task<TResponse?> DeleteAync<TResponse>(string endpoint);
}
