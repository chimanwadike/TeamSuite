using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamSuite.Contracts;

namespace TeamSuite.LoggerService
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLoggerService(this IServiceCollection services, IConfiguration configuration)
        {
            LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));
            services.AddSingleton<ILoggerManager, LoggerManager>();
            return services;
        }
    }
}
