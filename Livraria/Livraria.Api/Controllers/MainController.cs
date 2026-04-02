using Microsoft.AspNetCore.Mvc;

namespace Livraria.Api.Controllers
{
    public class MainController : ControllerBase
    {
        protected ActionResult CustomResponse(object result, List<string> erros)
        {
            if (erros is null || erros.Count == 0)
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = erros.ToArray()
            });
        }
    }
}
