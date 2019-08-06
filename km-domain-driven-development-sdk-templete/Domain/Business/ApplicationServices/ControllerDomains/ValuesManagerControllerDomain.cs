using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;

namespace KrunchyMonkey.DomainDrivenDesign.Domain.Business.ApplicationServices.ControllerDomains 
{
    public class ValuesManagerControllerDomain : IValuesManagerDomainController
    {
        private readonly IValuesManagerDomain _valuesManagerDomain;
        public ValuesManagerControllerDomain(
            IValuesManagerDomain valuesManagerDomain
        ) 
        {
            _valuesManagerDomain = valuesManagerDomain;
        }

        public string[] Values => _valuesManagerDomain.Values;
        
    }
}  