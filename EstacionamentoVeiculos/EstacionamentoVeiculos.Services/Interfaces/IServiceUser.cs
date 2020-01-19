using EstacionamentoVeiculos.Domain.Model;
using System;

namespace EstacionamentoVeiculos.Services.Interfaces
{
    public interface IServiceUser
    {
        Usuario GetUserById(Guid Id);
    }
}
