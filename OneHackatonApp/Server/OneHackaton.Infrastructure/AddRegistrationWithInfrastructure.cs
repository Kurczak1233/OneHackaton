using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OneHackaton.Domain.Contracts;
using OneHackaton.Infrastructure.Repositories;
using OneHackaton.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using MediatR;

namespace OneHackaton.Infrastructure
{
    public static class AddRegistrationWithInfrastructure
    {
        public static IServiceCollection AddOneHackatonServiceRegistration(this IServiceCollection services, IConfiguration configuration)
        {
            //DbContextRegistration
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //DapperRegistration
            services.AddTransient<ISqlConnectionService, SqlConnectionService>(_ => new SqlConnectionService(configuration.GetConnectionString("DefaultConnection")));
            //Services registration
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(AppDomain.CurrentDomain.Load("OneHackaton.API"));
            services.AddMediatR(AppDomain.CurrentDomain.Load("OneHackaton.Application"));
            services.AddMediatR(AppDomain.CurrentDomain.Load("OneHackaton.Domain"));
            services.AddMediatR(AppDomain.CurrentDomain.Load("OneHackaton.Infrastructure"));

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
