using KrunchyMonkey.DomainDrivenDesign.Business.Interfaces;

namespace KrunchyMonkey.DomainDrivenDesign.Business.ApplicationServices.ControllerDomains
{
    public class DependencyInjectionTestController : IDependencyInjectionTestController
    {
        private readonly IScopedInstancedDomain _scopedInstancedDomain;
        private readonly ISingletonInstancedDomain _singletonInstancedDomain;
        private readonly ITransientInstancedDomain _transientInstancedDomain;

        public DependencyInjectionTestController(
            IScopedInstancedDomain scopedInstancedDomain,
            ISingletonInstancedDomain singletonInstancedDomain,
            ITransientInstancedDomain transientInstancedDomain
            ) {
            _scopedInstancedDomain = scopedInstancedDomain;
            _singletonInstancedDomain = singletonInstancedDomain;
            _transientInstancedDomain = transientInstancedDomain;
        }
        public int ScopedValue => _scopedInstancedDomain.FetchValue();
        public int SingletonValue => _singletonInstancedDomain.FetchValue();
        public int TransientValue => _transientInstancedDomain.FetchValue();
    }
}
