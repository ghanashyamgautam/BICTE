using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container
            builder.Services.AddControllersWithViews();

            // Register the DbContext BEFORE calling builder.Build()
            if (builder.Environment.IsDevelopment())
            {
                // Use connection string from appsettings.Development.json
                builder.Services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            }
            else
            {
                // Use connection string from appsettings.json (Production/Staging)
                builder.Services.AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionConnection")));

            }

            // Build the application AFTER services are registered
            var app = builder.Build();

            // Exception handling for production
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
        }
    }
}
