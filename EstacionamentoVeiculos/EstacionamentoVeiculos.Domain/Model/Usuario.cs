using EstacionamentoVeiculos.Domain.Model.Base;
using System;

namespace EstacionamentoVeiculos.Domain.Model
{
    public class Usuario : CreateBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
