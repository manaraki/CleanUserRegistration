using CleanUserRegistration.Domain.Interfaces;
using CleanUserRegistration.Infra.Data.Context;
using CleanUserRegistration.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanUserRegistration.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // DbContext
            services.AddDbContext<UserContext>(options => options.UseSqlServer(connectionString:"Data Source=localhost;Initial Catalog=CleanUserDB;Integrated Security=true"));

            // Infra Data Layer
            services.AddScoped<IUserRepository, UserRepository>();

            // Application Layer
        }
    }
}
