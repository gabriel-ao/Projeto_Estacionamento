using EstacionamentoVeiculos.Infra.Entities.Base;
using System;

namespace EstacionamentoVeiculos.Infra.Entities
{
    public class Veiculo : EntityComplexBase
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }

        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
