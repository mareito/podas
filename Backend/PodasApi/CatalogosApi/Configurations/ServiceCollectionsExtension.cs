
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PodasApi.Catalogo.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;

namespace PodasApi.Catalogo.Configurations
{
    public static class ServiceCollectionsExtension
    {
        /// <summary>
        /// Metodo de extension para la configuracion de la conexion a la BD MYSQL
        /// </summary>
        /// <param name="services">Clase donde se crean los servicios</param>
        /// <returns></returns>
        public static IServiceCollection AddContextMysql(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContextPool<PodasContext>(options => options.UseMySql(configuration.GetConnectionString("MySql"), mySqlOptions => mySqlOptions.ServerVersion(new Version(10,1,36), ServerType.MariaDb)));

            return services;
        }

    }
}
