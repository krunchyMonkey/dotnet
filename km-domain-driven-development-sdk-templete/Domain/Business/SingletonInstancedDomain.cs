using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KrunchyMonkey.DomainDrivenDesign.Business
{
    public class SingletonInstancedDomain : ISingletonInstancedDomain
    {
        private int _value;

        public SingletonInstancedDomain()
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
