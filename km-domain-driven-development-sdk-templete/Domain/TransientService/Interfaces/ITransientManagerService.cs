using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Business.Transient.Interfaces
{
    public interface ITransientService
    {
        ITransientRepository TransientRepository { get; }
    }
}
