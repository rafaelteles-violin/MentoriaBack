using Livraria.Domain.Entity;

namespace Livraria.Domain.Interface
{
    public interface ILivroRepository
    {
        Task Adicionar(Livro entity);
        void Atualizar(Livro entity);
        Task<Livro> ObterLivroPorId(Guid id);
        Task<IEnumerable<Livro>> ObterTodos();
        void Remover(Livro livro);
    }
}
