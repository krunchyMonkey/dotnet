namespace KrunchyMonkey.DomainDrivenDesign.ValuesManager.Interface
{
    public interface IValuesManagerService 
    {
        IValuesManagerRepository ValuesManagerRepository { get; }
    }
}