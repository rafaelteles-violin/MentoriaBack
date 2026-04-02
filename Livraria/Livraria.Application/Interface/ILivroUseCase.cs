using Livraria.Application.DTO;
using Livraria.Application.Model;

namespace Livraria.Application.Interface
{
    public interface ILivroUseCase
    {
        Task<ServerStatus> Adicionar(LivroModel livrariaVm);
        Task<ServerStatus> Atualizar(LivroModel livrariaVm);
        Task<List<LivroDto>> ObterTodos();
        Task<LivroDto> ObterPorId(Guid id);
        Task<ServerStatus> Remover(Guid id);
    }
}
