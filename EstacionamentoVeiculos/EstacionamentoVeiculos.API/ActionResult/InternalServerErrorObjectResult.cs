using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EstacionamentoVeiculos.API.ActionResult
{
    public class InternalServerErrorObjectResult : ObjectResult
    {
        public InternalServerErrorObjectResult(object error) : base(error)
        {
            StatusCode = StatusCodes.Status500InternalServerError;
        }
    }
}
