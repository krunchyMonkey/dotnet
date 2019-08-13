using KrunchyMonkey.DomainDrivenDesign.Business;
using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Business.ValuesManager;
using KrunchyMonkey.DomainDrivenDesign.Domain.Business.ApplicationServices.ControllerDomains;
using KrunchyMonkey.DomainDrivenDesign.Domain.ValuesManager.Repositories;
using KrunchyMonkey.DomainDrivenDesign.Sdk.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.ValuesManager.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using KrunchyMonkey.DomainDrivenDesign.Business.ApplicationServices.ControllerDomains;
using KrunchyMonkey.DomainDrivenDesign.Business.Transient.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Business.Transient.Repositories;
using KrunchyMonkey.DomainDrivenDesign.Business.TransientService;

namespace KrunchyMonkey.DomainDrivenDesign.Sdk
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddKrunchyMonkeyDomainDrivenDesignSdk(this IServiceCollection services, IConfiguration configuration)
        {
            // Lazy Load Respository 
            services.AddScoped<IValuesManagerRepository, ValuesManagerRepository>()
                    .AddScoped(x => new Lazy<IValuesManagerRepository>(() => x.GetRequiredService<IValuesManagerRepository>()));
            services.AddTransient<ITransientRepository, TransientRepository>()
                    .AddTransient(x => new Lazy<ITransientRepository>(() => x.GetRequiredService<ITransientRepository>()));

            // Services
            services.AddScoped<IValuesManagerService, ValuesManagerService>();

            services.AddSingleton<ITransientService, TransientService>();

            // domains 
            services.AddScoped<IValuesManagerDomain, ValuesManagerDomain>();

            services.AddScoped<IScopedInstancedDomain, ScopedInstancedDomain>();
            services.AddScoped<ITransientInstancedDomain, TransientInstancedDomain>();
            services.AddScoped<ISingletonInstancedDomain, SingletonInstancedDomain>();
            
            // Controller Domains
            services.AddScoped<IValuesManagerDomainController, ValuesManagerControllerDomain>();
            services.AddScoped<IDependencyInjectionTestController, DependencyInjectionTestController>();

            // Get SDK
            services.AddScoped<IValuesSdk, ValuesSkd>();
            services.AddScoped<IDepencyInjectionTestSdk, DepencyInjectionTestSdk>();

            return services;
        }

    }
}
