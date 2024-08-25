using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HR_Management.Application
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        }

    }
}
