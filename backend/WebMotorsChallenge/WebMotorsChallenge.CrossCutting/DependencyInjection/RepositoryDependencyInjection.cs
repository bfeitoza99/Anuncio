using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Data.Repositories;
using WebMotorsChallenge.Domain.Interfaces.Repositories;

namespace WebMotorsChallenge.CrossCutting.DependencyInjection
{
    public static class RepositoryDependencyInjection
    {        
            public static IServiceCollection AddRepositories(this IServiceCollection services)
            {
                services.AddTransient<IUnitOfWork, UnitOfWork>();
                services.AddTransient<IAdvertisingRepository,AdvertisingRepository>();  
                return services;
            }
        
    }
}
