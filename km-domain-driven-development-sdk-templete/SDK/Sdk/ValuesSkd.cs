using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Sdk.Interfaces;
using System;

namespace KrunchyMonkey.DomainDrivenDesign.Skd
{
    public class ValuesSkd : IValuesSdk
    {
        private readonly IValuesManagerDomainController _valuesManagerDomainController;
        public string[] Values => _valuesManagerDomainController.Values;
        public ValuesSkd(
            IValuesManagerDomainController valuesManagerDomainController
        ) {
            _valuesManagerDomainController = valuesManagerDomainController;
        }    
    }
}
