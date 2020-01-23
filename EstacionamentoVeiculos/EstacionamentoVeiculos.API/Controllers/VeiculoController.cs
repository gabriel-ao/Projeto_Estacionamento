using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionamentoVeiculos.Domain.Exceptions;
using EstacionamentoVeiculos.Domain.Model;
using EstacionamentoVeiculos.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstacionamentoVeiculos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        public IServiceVeiculo _serviceVeiculo;
        public VeiculoController(IServiceVeiculo serviceVeiculo)
        {
            _serviceVeiculo = serviceVeiculo;
        }

        [HttpGet("BuscarVeiculo")]
        public Veiculo BuscarUsuario(Guid id)
        {
            return _serviceVeiculo.GetVeiculoById(id);
        }

        [HttpGet("BuscarTodosVeiculos")]
        public List<Veiculo> BuscarTodosVeiculosController()
        {
            return _serviceVeiculo.GetAllVeiculoById();
        }


        [HttpPost("CadastrarVeiculo")]
        public string CadastrarVeiculoController(Veiculo veiculo)
        {
            try
            {
                _serviceVeiculo.CadastrarVeiculoService(veiculo);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }
            return "veiculo cadastrado com sucesso";
        }


        [HttpPut("EditarVeiculo")]
        public string EditarVeiculoController(Veiculo veiculo)
        {
            try
            {
                _serviceVeiculo.EditarVeiculoService(veiculo);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }
            return "Veiculo editado com sucesso";
        }

        [HttpPost("AtivarVeiculo")]
        public string AtivarVeiculoController(Guid id)
        {
            string retorno = "";
            try
            {
                retorno = _serviceVeiculo.AtivarVeiculoService(id);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }
            return retorno;
        }

        [HttpDelete("DesativarVeiculo")]
        public string DesativarVeiculoController(Guid id)
        {
            string retorno = "";
            try
            {
                retorno = _serviceVeiculo.DesativarVeiculoService(id);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {
                Console.WriteLine(error);
            }
            return retorno;
        }

        [HttpDelete("DeletarVeiculo")]
        public string DeletarVeiculoController(Guid id)
        {
            try
            {
                _serviceVeiculo.DeletarVeiculoService(id);
            }
            catch (EstacionamentoVeiculosExceptions error)
            {

                Console.WriteLine(error);
            }
            return "veiculo Deletado com sucesso";
        }
    }
}