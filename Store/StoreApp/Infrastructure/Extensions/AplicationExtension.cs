using Microsoft.EntityFrameworkCore;
using Repositories;

namespace StoreApp.Infrastructure.Extensions
{
    
public static class AplicationExtension
{
    public static void ConfigureAndCheckMigration(this IApplicationBuilder app)

    {

RepositoryContext context=app
.ApplicationServices
.CreateScope()
.ServiceProvider
.GetRequiredService<RepositoryContext>();
if(context.Database.GetPendingMigrations().Any())
{
    context.Database.Migrate();
}

    }
    

    public static void ConfigureLocalization(this WebApplication app)
    {
 app.UseRequestLocalization(options=>{
    options.AddSupportedCultures("tr-TR")
    .AddSupportedUICultures("tr-TR")
    .SetDefaultCulture("tr-TR");
 });
    }



public static void ConfigureDefaultAdminUser(this IApplicationBuilder app )
{
const string adminUser="Admin";
const string adminPassword="123456";


}


}

}