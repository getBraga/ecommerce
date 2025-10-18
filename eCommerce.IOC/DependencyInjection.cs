using eCommerce.Application;
using eCommerce.Application.interfaces;
using eCommerce.Models.interfaces;
using eCommerce.Repository.context;
using eCommerce.Repository.repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eCommerce.IOC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)

        {
            //    services.AddDbContext<ECommerceContext>(options =>
            //options.UseSqlServer(configuration.GetConnectionString("eCommerceContext"
            //), b => b.MigrationsAssembly(typeof(ECommerceContext).Assembly.FullName)));

            services.AddDbContext<ECommerceContext>(options =>   
                    options.UseSqlServer(configuration.GetConnectionString("eCommerce"))    
                );


            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            return services;
        }
    }
}
