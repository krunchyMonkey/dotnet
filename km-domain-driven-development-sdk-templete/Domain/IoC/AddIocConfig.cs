using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.IoC
{
    public static class AddIocConfig
    {
        public static IServiceCollection AddFromIocConfig<T>(this IServiceCollection services,
                                               IConfiguration configuration,
                                               Func<T, IServiceCollection,
                                               IConfiguration,
                                               IServiceCollection> configAction) where T : IocConfiguration
        {
            var iocConfig = Activator.CreateInstance<T>();
            configAction(iocConfig, services, configuration);
            return services;
        }
    }
}
