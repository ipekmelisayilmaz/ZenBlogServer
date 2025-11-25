using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using ZenBlog.Application.Behaviors;

namespace ZenBlog.Application.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddApplication(this IServiceCollection services)
        {
            // Application katmanına özgü servis kayıtları buraya eklenecek
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                options.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
