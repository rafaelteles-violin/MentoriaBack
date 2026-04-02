using Livraria.Domain.Entity;
using Livraria.Domain.Interface;
using Livraria.Infra.Data;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infra.Repository
{
    public class LivroRepository(LivrariaContext contexto) : ILivroRepository
    {
        public async Task Adicionar(Livro entity)
        {
            await contexto.Livro.AddAsync(entity);
            await contexto.SaveChangesAsync();
        }

        public void Atualizar(Livro entity)
        {
            contexto.Livro.Update(entity);
            contexto.SaveChanges();
        }

        public async Task<Livro> ObterLivroPorId(Guid id)
        {
            return await contexto.Livro.FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Livro>> ObterTodos()
        {
            return await contexto.Livro.AsNoTracking()
               .ToListAsync();
        }

        public void Remover(Livro livro)
        {
            contexto.Livro.RemoveRange(livro);
            contexto.SaveChanges();
        }
    }
}
