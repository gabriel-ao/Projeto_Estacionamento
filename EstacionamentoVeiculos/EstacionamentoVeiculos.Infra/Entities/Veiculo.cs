using EstacionamentoVeiculos.Infra.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoVeiculos.Infra.Entities
{
    public class Veiculo : EntityComplexBase
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
    }
}
