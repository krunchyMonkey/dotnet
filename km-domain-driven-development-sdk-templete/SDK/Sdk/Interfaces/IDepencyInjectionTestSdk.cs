using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Sdk.Interfaces
{
    public interface IDepencyInjectionTestSdk
    {
        int ScopedValue { get; }
        int SingletonValue { get; }
        int TransientValue { get; }
    }
}
