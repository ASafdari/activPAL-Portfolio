using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Application.Common.Interfaces;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PortfolioDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PortfolioDatabase")));

            services.AddScoped<IPortfolioDbContext>(provider => provider.GetService<PortfolioDbContext>());

            return services;
        }
    }
}