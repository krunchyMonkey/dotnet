using KrunchyMonkey.DomainDrivenDesign.Business;
using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Business.ValuesManager;
using KrunchyMonkey.DomainDrivenDesign.Domain.Business.ApplicationServices.ControllerDomains;
using KrunchyMonkey.DomainDrivenDesign.Domain.ValuesManager.Repositories;
using KrunchyMonkey.DomainDrivenDesign.Sdk.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Sdk;
using KrunchyMonkey.DomainDrivenDesign.ValuesManager.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Sdk
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddKrunchyMonkeyDomainDrivenDesignSdk(this IServiceCollection services, IConfiguration configuration)
        {
            // Lazy Load Respository 
            services.AddScoped<IValuesManagerRepository, ValuesManagerRepository>()
                    .AddScoped(x => new Lazy<IValuesManagerRepository>(() => x.GetRequiredService<IValuesManagerRepository>()));

            // Services
            services.AddScoped<IValuesManagerService, ValuesManagerService>();

            // domains 
            services.AddScoped<IValuesManagerDomain, ValuesManagerDomain>();

            // Controller Domains
            services.AddScoped<IValuesManagerDomainController, ValuesManagerControllerDomain>();

            // Get SDK
            services.AddScoped<IValuesSdk, ValuesSkd>();

            return services;
        }

    }
}
