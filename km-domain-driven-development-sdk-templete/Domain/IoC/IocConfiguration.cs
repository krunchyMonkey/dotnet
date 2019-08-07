using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace KrunchyMonkey.DomainDrivenDesign.IoC
{
    public abstract class IocConfiguration
    {
        public abstract IServiceCollection Load(IServiceCollection service, IConfiguration configuration);
    }
}
