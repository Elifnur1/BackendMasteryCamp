//Buradaki tüm kodlar aslında Main metodunun içindeler.
var builder = WebApplication.CreateBuilder(args); //Bir web application oluşturucu yaratılıyor.

//Bu satırla bu uygulamanın bir MVC uygulaması olucağı belirtiliyor.
builder.Services.AddControllersWithViews();

var app = builder.Build(); //Bir web application(MVC) oluşturuluyor.

// Bu aşamadan run yapılana kadar olan kısımda gelen istekler yapılandırılıyor.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); //http üzerinden gelen istekleri https'e yönlendirir.
app.UseStaticFiles(); //wwwrot klosörünün kullanılabilir olmasını sağlar.

app.UseRouting();//Gelen isteklerin hangi controllere'a gitmesi gerektiğini belirler.

app.UseAuthorization(); //Yetkilendirme özelliklerini aktif kılar.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); 
    //

app.Run(); //Oluşulun web application burada çalıştırılıyor.
