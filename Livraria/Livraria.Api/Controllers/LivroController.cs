using Livraria.Application.DTO;
using Livraria.Application.Interface;
using Livraria.Application.Model;
using Livraria.Application.UseCase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController(ILivroUseCase livroUseCase) : MainController
    {
        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] LivroModel livroModel)
        {
            var result = await livroUseCase.Adicionar(livroModel);
            return CustomResponse(result, result.Erros);
        }


        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] LivroModel livroModel)
        {
            var result = await livroUseCase.Atualizar(livroModel);
            return CustomResponse(result, result.Erros);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remover(Guid id)
        {
            try
            {
                var result = await livroUseCase.Remover(id);
                return CustomResponse(result, result.Erros);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<LivroDto> ObterPorId(Guid id)
        {
            return await livroUseCase.ObterPorId(id);
        }

        [HttpGet]
        public async Task<List<LivroDto>> ObterTodosProdutos()
        {
            return await livroUseCase.ObterTodos();
        }
    }
}
