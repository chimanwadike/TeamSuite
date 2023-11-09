using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using TeamSuite.Contracts;
using TeamSuite.Entities.Models;
using TeamSuite.LoggerService;
using TeamSuite.Repository;
using TeamSuite.Service;

namespace TeamSuite.Web.Extensions
{
    public static class ServiceExtension
    {
        public static IServiceCollection ConfigureDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<RepositoryContext>(options =>
                options.UseNpgsql(connectionString, _ => _.MigrationsAssembly("TeamSuite.Repository")));

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<RepositoryContext>();            

            return services;
        }

        public static void ConfigureLoggerManager(this IServiceCollection services) =>
            services.AddScoped<ILoggerManager, LoggerManager>();

        public static void ConfigureRepositoryManager(this IServiceCollection services) => 
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) => 
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureMapper(this IServiceCollection services) =>
            services.AddAutoMapper(typeof(Program));
    }
}
