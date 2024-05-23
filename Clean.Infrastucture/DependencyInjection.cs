using Clean.Application.Interfaces;
using Clean.Infrastucture.Persistence;
using Clean.Infrastucture.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.Infrastucture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastucture(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(config.GetConnectionString("defaultConnection")));
            return services;
        }
    }
}
