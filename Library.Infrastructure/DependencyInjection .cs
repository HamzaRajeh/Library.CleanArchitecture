using Library.Domain.Models;
using Library.Infrastructure.Services.Tbbook;
using Library.Infrastructure.Services.Tbrent;
using Library.Infrastructure.Services.UserAdmin;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Library.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration Configuration)
        {


            services.AddTransient<IUserAdminServices, UserAdminServices>();
            services.AddSqlServer<DblibraryContext>(Configuration.GetConnectionString("ConnectionStrings"));
            services.AddTransient<ITbbookServices, TbbookServices>();
            services.AddTransient<ITbrentServices, TbrentServices>();
            return services;
        }
    }
}