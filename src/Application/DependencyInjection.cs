using System.Reflection;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Portfolio.Application.Common.Behaviours;

namespace Portfolio.Application
{
    /// <summary>
    /// Inject all components in this assembly
    /// </summary>
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Inject Mapping Profiles
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Inject Messaging Pipeline
            services.AddMediatR(Assembly.GetExecutingAssembly());

            // Inject Mediatr Pipeline behaviours
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }
    }
}