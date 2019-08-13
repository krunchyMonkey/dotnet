using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Sdk.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Sdk
{
    public class DepencyInjectionTestSdk : IDepencyInjectionTestSdk
    {
        private readonly IDependencyInjectionTestController _dependencyInjectionTestController;
        public DepencyInjectionTestSdk(
            IDependencyInjectionTestController dependencyInjectionTestController)
        {
            _dependencyInjectionTestController = dependencyInjectionTestController;
        }

        public int ScopedValue => _dependencyInjectionTestController.ScopedValue;
        public int SingletonValue => _dependencyInjectionTestController.SingletonValue;
        public int TransientValue => _dependencyInjectionTestController.TransientValue;
    }
}
