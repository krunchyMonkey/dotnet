using System;
using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.ValuesManager.Interface;

namespace KrunchyMonkey.DomainDrivenDesign.Business
{
    public class ValuesManagerDomain : IValuesManagerDomain
    {
        private readonly IValuesManagerService _valuesManagerService;

        public ValuesManagerDomain(
            IValuesManagerService valuesManagerService
        ){
            _valuesManagerService = valuesManagerService;
        }
        public string[] Values => _valuesManagerService.ValuesManagerRepository.Values;
        
    }
}
