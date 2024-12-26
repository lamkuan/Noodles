using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Noodles.Models;
using Microsoft.AspNetCore.Identity;

namespace Noodles;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvc();
        builder.Services.AddTransient<INoodleRepository, NoodleRepository>();
        builder.Services.AddTransient<IFeedbackRepository, FeedbackRepository>();
        builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("MysqlConnection"), new MySqlServerVersion(new Version(8, 0, 28))));
        
        builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<AppDbContext>();
        
        var app = builder.Build();
        
        app.UseStaticFiles();
        app.UseAuthentication();
        app.UseAuthorization();

        // app.MapControllers();

        app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
        app.MapRazorPages();

        app.Run();
    }
}
