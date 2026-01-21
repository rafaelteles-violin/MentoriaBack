using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResutPattent
{
    public class Pessoa
    {
        public string Nome { get; }
        public string Cpf { get; }
        public string Telefone { get; }

        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public static Result<Pessoa> Criar(string nome, string cpf, string telefone)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(nome))
                errors.Add("Nome é obrigatório.");

            if (string.IsNullOrWhiteSpace(cpf))
                errors.Add("CPF é obrigatório.");

            if (string.IsNullOrWhiteSpace(telefone))
                errors.Add("Telefone é obrigatório.");

            if (errors.Any())
                return Result<Pessoa>.Failure(errors);

            var pessoa = new Pessoa(nome, cpf, telefone);

            return Result<Pessoa>.Success(pessoa);
        }
    }

}
