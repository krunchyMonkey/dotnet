using KrunchyMonkey.DomainDrivenDesign.ValuesManager.Interface;

namespace KrunchyMonkey.DomainDrivenDesign.Domain.ValuesManager.Repositories 
{
    public class ValuesManagerRepository : IValuesManagerRepository 
    {
        public string[] Values => new string[]  { "Values1", "Values2" }; 
    }
}