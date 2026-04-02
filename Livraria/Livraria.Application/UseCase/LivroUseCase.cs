using Livraria.Application.DTO;
using Livraria.Application.Interface;
using Livraria.Application.Model;
using Livraria.Domain.Entity;
using Livraria.Domain.Interface;

namespace Livraria.Application.UseCase
{
    public class LivroUseCase(ILivroRepository livroRepository) : ILivroUseCase
    {
        public async Task<ServerStatus> Adicionar(LivroModel livroVm)
        {
            var livro = new Livro(livroVm.Nome, livroVm.AnoLancamento, livroVm.Autor);

            if (livro.ValidarLivro().Any())
                return await Task.FromResult(new ServerStatus(
                    livro.ValidarLivro().Select(x=>x.Message)
                    .ToList()));

            await livroRepository.Adicionar(livro);

            return await Task.FromResult(new ServerStatus("Livro adicionado com sucesso!"));
        }

        public async Task<ServerStatus> Atualizar(LivroModel livroVm)
        {
            var livro = await livroRepository.ObterLivroPorId(livroVm.Id);

            livro.AtualizarLivro(livroVm.Nome, livroVm.AnoLancamento, livroVm.Autor);

            if (livro.ValidarLivro().Any())
                return await Task.FromResult(new ServerStatus(
                    livro.ValidarLivro().Select(x => x.Message)
                    .ToList()));

             livroRepository.Atualizar(livro);

            return await Task.FromResult(new ServerStatus("Livro atualizado com sucesso!"));
        }

        public async Task<LivroDto> ObterPorId(Guid id)
        {
            var livro = await livroRepository.ObterLivroPorId(id);

            return new LivroDto(livro.Id, livro.Nome, livro.AnoLancamento, livro.Autor);
        }

        public async Task<List<LivroDto>> ObterTodos()
        {
            var livrosDto = new List<LivroDto>();

            var livros = await livroRepository.ObterTodos();

            if (!livros.Any())
                return livrosDto;

            foreach (var livro in livros)
            {
                livrosDto.Add(new LivroDto(livro.Id, livro.Nome, livro.AnoLancamento, livro.Autor));
            }

            return livrosDto;
        }

        public async Task<ServerStatus> Remover(Guid id)
        {
            var livro = await livroRepository.ObterLivroPorId(id);
            livroRepository.Remover(livro);

            return await Task.FromResult(new ServerStatus("Livro removido com sucesso!"));
        }
    }
}
