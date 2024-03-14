

using Core.Applicantion.Pipelines.Logging;
using Core.Applicantion.Pipelines.Performans;
using Core.Applicantion.Pipelines.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.CrossCuttingConcerns.Logging.Serilog;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Reflection;
using FluentValidation;

namespace Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddScoped<Stopwatch>();

            services.AddSingleton<LoggerServiceBase, MongoDbLogger>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

            return services;
        }
    }
}
