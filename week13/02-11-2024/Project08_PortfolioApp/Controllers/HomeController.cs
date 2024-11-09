using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Project08_PortfolioApp.Models;

namespace Project08_PortfolioApp.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult>Index()
    {
        //bağlantı oluşturuyoruz.
        var connectionString = "Server=localhost,1441;Database=PortfolioDb;User=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=true";
        var connection=new SqlConnection(connectionString);
        //site ayarlarını çekiyoruz.
        var queryAppSetting = "select * from AppSettings";
        var appSetting=(await connection.QueryAsync<AppSetting>(queryAppSetting)).First();

        //Category listesini çekiyoruz.
        var queryCategories="Select * from Categories";
        var Categories=await connection.QueryAsync<Category>(queryCategories);
        
        //Project listesini çekiyoruz.
        var queryProjects="select * from Projects";
        var Projects=await connection.QueryAsync<Project>(queryProjects);

        //Skill listesini çekiyoruz.
        var querySkills="select * from Skills";
        var Skills=await connection.QueryAsync<Skill>(querySkills);

        //service listesini çekiyoruz.
        var queryServices="select * from Services";
        var Services=await connection.QueryAsync<Service>(queryServices);

        //Social listesini çekiyoruz
        var querySocials="selet * from Socials";
        var Socials=await connection.QueryAsync<Social>(querySocials);

        HomePageModel model=new()
        {
            AppSetting = appSetting,
            Categories=Categories,
            Projects= Projects,
            Services=Services,
            Skills=Skills,
            Socials =Socials
        };

        return View();
    }
}
