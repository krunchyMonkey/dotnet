using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Business.Transient.Interfaces;
using KrunchyMonkey.DomainDrivenDesign.Business.TransientService;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Business
{
    public class TransientInstancedDomain: ITransientInstancedDomain
    {
        private readonly ITransientService _transientService;

        public TransientInstancedDomain(ITransientService transientService)
        {
            _transientService = transientService;
        }

        public int FetchValue()
        {
            return _transientService.TransientRepository.FetchValue();
        }
    }
}
