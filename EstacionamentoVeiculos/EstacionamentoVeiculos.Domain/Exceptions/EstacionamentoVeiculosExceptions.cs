using System;

namespace EstacionamentoVeiculos.Domain.Exceptions
{
    public class EstacionamentoVeiculosExceptions : Exception
    {
        public EstacionamentoVeiculosExceptions()
        {

        }

        public EstacionamentoVeiculosExceptions(string message) : base(message)
        {

        }

        public EstacionamentoVeiculosExceptions(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
