using EstacionamentoVeiculos.Domain.Model;
using System;
using System.Collections.Generic;

namespace EstacionamentoVeiculos.Services.Interfaces
{
    public interface IServiceUser
    {
        Usuario GetUserById(Guid Id);
        List<Usuario> GetAllUserById();
        string CadastrarUsuario(Usuario user);
        Usuario EditarUsuario(Usuario user);
        string DesativarUsuarioService(Guid id);
        string DeletarUsuarioService(Guid id);
        string AtivarUsuarioService(Guid id);


    }
}
