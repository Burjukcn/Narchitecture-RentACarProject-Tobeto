

using Application.Service.AuthServices.AuthService;
using Application.Service.AuthServices.UserService;
using Application.Service.CarImageServicee;
using Core.Applicantion.Pipelines.Authorization;
using Core.Applicantion.Pipelines.Caching;
using Core.Applicantion.Pipelines.Logging;
using Core.Applicantion.Pipelines.Performans;
using Core.Applicantion.Pipelines.Validation;
using Core.CrossCuttingConcerns.Logging.Serilog;
using Core.CrossCuttingConcerns.Logging.Serilog.Loggers;
using Core.Security.JWT;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using System.Reflection;

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

            services.AddScoped<CarImageBusinessRules>();
            services.AddScoped<ICarImageService, CarImageManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IAuthService, AuthManager>();
            services.AddSingleton<TokenOptions>();


            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            return services;
        }
    }
}

//Bu kod bloğu, uygulamanın kullandığı çeşitli kütüphaneleri ve hizmetleri dependency injection sistemine ekleme işlemlerini yapar. Bu sayede, uygulamanın farklı katmanları, bu hizmetlere ihtiyaç duyduklarında dependency injection aracılığıyla kolayca erişebilir ve kullanabilirler. Bu da, uygulamanın test edilebilirliğini, bakımını ve yönetilebilirliğini kolaylaştırır.
