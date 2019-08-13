using KrunchyMonkey.DomainDrivenDesign.Business.Transient.Interfaces;

namespace KrunchyMonkey.DomainDrivenDesign.Business.Transient.Repositories 
{
    public class TransientRepository : ITransientRepository
    {
        private int _value;
        public TransientRepository() 
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