namespace EstacionamentoVeiculos.Infra.Interfaces
{
    public interface IRepositoryUnityOfWork
    {
        //IRepositoryUser Users { get; }
        bool Commit();
    }
}
