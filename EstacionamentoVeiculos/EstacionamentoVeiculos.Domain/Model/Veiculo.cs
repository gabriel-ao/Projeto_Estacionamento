using EstacionamentoVeiculos.Domain.Model.Base;
using System;

namespace EstacionamentoVeiculos.Domain.Model
{
    public class Veiculo : CreateBase
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public Guid IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
