using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ResutPattent
{
    public class PessoaController
    {
        [HttpPost]
        public IActionResult CriarPessoa(CriarPessoaRequest request)
        {
            var result = _pessoaService.CriarPessoa(
                request.Nome,
                request.Cpf,
                request.Telefone
            );

            if (result.IsFailure)
                return BadRequest(result.Errors);

            return Ok();
        }

    }
}
