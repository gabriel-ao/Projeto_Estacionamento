using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet("BuscarCliente")]
        public Usuario BuscarCliente(Guid id)
        {
            return _serviceUser.GetUserById(id);
        }
    }
}