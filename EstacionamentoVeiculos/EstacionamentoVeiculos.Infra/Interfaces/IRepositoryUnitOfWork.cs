namespace EstacionamentoVeiculos.Infra.Interfaces
{
    public interface IRepositoryUnitOfWork
    {
        //IRepositoryUser Users { get; }
        bool Commit();
    }
}
