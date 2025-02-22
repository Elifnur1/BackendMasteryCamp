using System;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace EShop.MVC.Services.Interfaces;

public class HttpClientService : IHttpClientService
{
    private readonly HttpClient _httpClient;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly JsonSerializerOptions _jsonSerializerOptions;
    
    public HttpClientService(HttpClient httpClient, IHttpContextAccessor httpContextAccessor, JsonSerializerOptions jsonSerializerOptions, IAuthService authService)
    {
        _httpClient = httpClient;
        _httpContextAccessor = httpContextAccessor;
        _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
       
    }
    private async Task SetAuthorizationHeader()
    {
        var token = await _httpContextAccessor.HttpContext!.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        var token =authResult.Properties!.Items("access-token");
        if (!string.IsNullOrEmpty(token))
        {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }
        else
        {
            System.Console.WriteLine("Token bulunamadı");//Loglama ile ilgili daha merkezi bir operasyon yapılabilir.
        }
    }
    public async Task<TResponse?> GetAsync<TResponse>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);
        var responseContent = await response.Content.ReadAsStringAsync();
        if (string.IsNullOrWhiteSpace(responseContent) && response.IsSuccessStatusCode)
        {
            //API'dan başarılı ama içeriği boş bir yanıt döndüyse
            return (TResponse)Activator.CreateInstance(typeof(TResponse))!;
            try
            {
                var result = JsonSerializer.Deserialize<TResponse>(responseContent, _jsonSerializerOptions);
                return result;
            }
            catch (Exception ex)
            {

                System.Console.WriteLine($"Hata:{ex.Message}");
                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Status:{response.StatusCode}, Message:{response.Content}");
                }
                throw new Exception($"Hata:{ex.Message}");
            }
        }
        ;
    }

    public Task<TResponse?> DeleteAync<TResponse>(string endpoint)
    {
        throw new NotImplementedException();
    }

    public Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<TResponse?> PostFromAsync<TResponse>(string endpoint, MultipartFormDataContent formData)
    {
        throw new NotImplementedException();
    }

    public Task<TResponse?> PutAsync<TResponse>(string endpoint, MultipartFormDataContent formData)
    {
        throw new NotImplementedException();
    }

    public Task<TResponse?> PutFromAsync<TResponse>(string endpoint, MultipartFormDataContent formData)
    {
        throw new NotImplementedException();
    }
}
