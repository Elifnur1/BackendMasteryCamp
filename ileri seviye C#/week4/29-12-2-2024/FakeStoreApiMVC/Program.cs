using _29_12_2024.Models;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

//ApiSettings konfigüre ediliyor.
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("FakeStoreApi"));

//HttpClient ApiSetting ile konfigüre ediliyor
builder.Services.AddHttpClient("FafeStoreApi",(serviceProvider,client)=>{
    ApiSettings apiSetting=serviceProvider.GetRequiredService<IOptions<ApiSettings>>().Value;
    client.BaseAddress=new Uri(apiSetting.BaseUrl);
});




var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
