using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Business.Interfaces
{
    public interface IDependencyInjectionTestController
    {
        int ScopedValue { get; }
        int SingletonValue { get; }
        int TransientValue { get; }
    }
}
