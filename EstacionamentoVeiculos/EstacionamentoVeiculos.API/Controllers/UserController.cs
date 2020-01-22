using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionamentoVeiculos.Domain.Exceptions;
using EstacionamentoVeiculos.Domain.Model;
using EstacionamentoVeiculos.Services.Interfaces;
using EstacionamentoVeiculos.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstacionamentoVeiculos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IServiceUser _serviceUser;
        public UserController(IServiceUser serviceUser)
        {
            _serviceUser = serviceUser;
        }

        [HttpGet("BuscarUsuario")]
        public Usuario BuscarUsuario(Guid id)
        {
            return _serviceUser.GetUserById(id);
        }

        [HttpGet("BuscarTodosUsuarios")]
        public List<Usuario> BuscarTodosUsuarios()
        {
            return _serviceUser.GetAllUserById();
        }

        [HttpPost("CadastrarUsuario")]
        public string CadastrarUsuario(Usuario user)
        {
            try
            {
                _serviceUser.CadastrarUsuario(user);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {

                Console.WriteLine(error);
            }
            return "usuario cadastrado com sucesso";
        }

        [HttpPut("EditarUsuario")]
        public string EditarUsuario(Usuario user)
        {
            try
            {
                _serviceUser.EditarUsuario(user);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }

            return "Usuario editado com sucesso";
        }

        [HttpDelete("DesativarUsuario")]
        public string DesativarUsuario(Guid id)
        {
            string retorno = "";
            try
            {
                retorno = _serviceUser.DesativarUsuarioService(id);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }

        [HttpPost("AtivarUsuario")]
        public string AtivarUsuario(Guid id)
        {
            string retorno = "";
            try
            {
                retorno = _serviceUser.AtivarUsuarioService(id);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }


        [HttpDelete("DelecaoDefinitiva")]
        public string DeletarUsuarioDefinitivo(Guid id)
        {
            string retorno = "";
            try
            {
                retorno = _serviceUser.DeletarUsuarioService(id);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }

            return retorno;
        }

    }
}