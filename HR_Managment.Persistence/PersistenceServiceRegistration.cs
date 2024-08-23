using HR_Management.Application.Persistence.Contracts;
using HR_Managment.Persistence.Contexts;
using HR_Managment.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HR_Managment.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurationPersistenceService(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<LeaveManagmentContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString(""));
            });

            #region Ioc
            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
       
            #endregion

            return services;
        }
    }
}
