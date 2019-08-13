using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Business
{
    public class ScopedInstancedDomain : IScopedInstancedDomain
    {
        private int _value;
        public ScopedInstancedDomain()
        {
            _value = 0;
        }

        public int FetchValue()
        {
            _value++;
            return _value;
        }
    }
}
