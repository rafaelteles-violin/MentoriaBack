using Livraria.Domain.Common;

namespace Livraria.Domain.Entity
{
    public class Livro
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public int AnoLancamento { get; private set; }
        public string Autor { get; private set; }

        public Livro(string nome, int anoLancamento, string autor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            AnoLancamento = anoLancamento;
            Autor = autor;
        }

        public void AtualizarLivro(string nome, int anoLancamento, string autor)
        {
            Nome = nome;
            Autor = autor;
            AnoLancamento = anoLancamento;
        }

        public List<ValidationError> ValidarLivro()
        {
            var errors = new List<ValidationError>();

            if (string.IsNullOrWhiteSpace(Nome))
                errors.Add(new ValidationError("Nome é obrigatório."));

            if (AnoLancamento >= 2026)
                errors.Add(new ValidationError("Ano lançamento deve ser maior que zero."));

            if (string.IsNullOrWhiteSpace(Autor))
                errors.Add(new ValidationError("Autor é obrigatório."));

            return errors;
        }
    }
}
