using EstacionamentoVeiculos.Infra.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoVeiculos.Infra.Entities
{
    public class Usuario : EntityComplexBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
