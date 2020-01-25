using EstacionamentoVeiculos.Domain.Model.Base;
using System;
using System.Collections.Generic;

namespace EstacionamentoVeiculos.Domain.Model
{
    public class Usuario : CreateBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Veiculo> Veiculos { get; set; }

    }
}
