using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Application.AppServices;
using WebMotorsChallenge.Domain.Interfaces.Service;

namespace WebMotorsChallenge.CrossCutting.DependencyInjection
{
    public static class ServiceDependencyInjection
    {

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IChallengeIntegrationService, ChallengeIntegrationService>();
            
            return services;
        }
    }
}
