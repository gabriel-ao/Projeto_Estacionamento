using EstacionamentoVeiculos.Domain.Interfaces;

namespace EstacionamentoVeiculos.Infra.Interfaces
{
    public interface IRepositoryUnitOfWork
    {
        IRepositoryUsuario Users { get; }
        IRepositoryVeiculo Veiculos { get; }
        bool Commit();
    }
}
