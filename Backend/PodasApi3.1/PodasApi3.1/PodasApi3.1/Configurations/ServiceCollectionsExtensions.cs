using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PodasApi.Entities.Tables;
using PodasApi3._1.DataContext;
using PodasApi3._1.Services;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace PodasApi3._1.Configurations
{
    public static class ServiceCollectionsExtensions
    {

        public static IServiceCollection AddDbContextMySql(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContextPool<PodasContext>(options => options
            .UseMySql(configuration.GetConnectionString("MySql"), mySqlOptions => mySqlOptions.ServerVersion(new Version(10, 1, 36), ServerType.MariaDb)));
            return services;
        }

        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddTransient<ITipoEmplazamiento, TipoEmplazamientoService>();
            return services;
        }
    }
}
