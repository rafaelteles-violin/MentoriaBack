using ApiApplication.Model;
using Microsoft.AspNetCore.Mvc;

namespace ApiApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private static List<ProdutoModel> listaProdutos = new List<ProdutoModel>
    {
        new ProdutoModel { Id = 1, Nome = "Teclado", Preco = 150 },
        new ProdutoModel { Id = 2, Nome = "Mouse", Preco = 80 },
        new ProdutoModel { Id = 2, Nome = "Fone de ouvido", Preco = 120 }
    };

        [HttpGet]
        public ActionResult<IEnumerable<ProdutoModel>> Get()
        {
            return listaProdutos;
        }

        [HttpGet("{id}")]
        public ActionResult<ProdutoModel> GetById(int id)
        {
            var produto = listaProdutos.FirstOrDefault(p => p.Id == id);
            if (produto == null) return NotFound();
            return produto;
        }

        [HttpPost]
        public ActionResult<ProdutoModel> Post(ProdutoModel novoProduto)
        {
            novoProduto.Id = listaProdutos.Max(p => p.Id) + 1;
            listaProdutos.Add(novoProduto);
            return CreatedAtAction(nameof(GetById), new { id = novoProduto.Id }, novoProduto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, ProdutoModel produto)
        {
            var produtoFind = listaProdutos.FirstOrDefault(p => p.Id == id);
            if (produtoFind == null) return NotFound();

            produtoFind.Nome = produto.Nome;
            produtoFind.Preco = produto.Preco;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = listaProdutos.FirstOrDefault(p => p.Id == id);
            if (produto == null) return NotFound();

            listaProdutos.Remove(produto);
            return NoContent();
        }
    }
}
