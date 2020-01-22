using EstacionamentoVeiculos.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoVeiculos.Services.Interfaces
{
    public interface IServiceVeiculo
    {
        Veiculo GetVeiculoById(Guid id);
        List<Veiculo> GetAllVeiculoById();
        string CadastrarVeiculoService(Veiculo veiculo);
        string EditarVeiculoService(Veiculo veiculo);
        string DesativarVeiculoService(Guid id);
        string AtivarVeiculoService(Guid id);
        string DeletarVeiculoService(Guid id);

    }
}
