using System.Collections.Generic;
using EstacionamentoVeiculos.Infra.Entities.Base;

namespace EstacionamentoVeiculos.Infra.Entities
{
    public class Usuario : EntityComplexBase
    {
        public Usuario()
        {
            this.Veiculos = new List<Veiculo>();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public IList<Veiculo> Veiculos { get; set; }


    }
}
