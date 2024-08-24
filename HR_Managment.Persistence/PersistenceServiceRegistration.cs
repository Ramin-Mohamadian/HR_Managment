using HR_Management.Application.Contracts.Persistences;
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
                options.UseSqlServer(configuration.GetConnectionString("LeaveConnectionString"));
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
