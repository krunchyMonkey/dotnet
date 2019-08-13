using KrunchyMonkey.DomainDrivenDesign.Business.Transient.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Business.TransientService
{
    public class TransientService : ITransientService
    {
        private readonly Lazy<ITransientRepository> _transientRepository;

        public ITransientRepository TransientRepository => _transientRepository.Value;
        public TransientService(Lazy<ITransientRepository> transientRepository)
        {
            _transientRepository = transientRepository;
        }

    }
}
