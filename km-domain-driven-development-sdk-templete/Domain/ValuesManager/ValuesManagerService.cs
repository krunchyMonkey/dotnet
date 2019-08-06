using System;
using KrunchyMonkey.DomainDrivenDesign.ValuesManager.Interface;

namespace KrunchyMonkey.DomainDrivenDesign.Business.ValuesManager 
{
    public class ValuesManagerService : IValuesManagerService 
    {
        private readonly Lazy<IValuesManagerRepository> _valuesManagerRepository;
        public IValuesManagerRepository ValuesManagerRepository => _valuesManagerRepository.Value;

        public ValuesManagerService(Lazy<IValuesManagerRepository> valuesManagerRepository) 
        {
            _valuesManagerRepository = valuesManagerRepository;
        }
    }
}
