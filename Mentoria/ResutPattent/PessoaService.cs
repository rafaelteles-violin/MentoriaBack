using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResutPattent
{
    public class PessoaService
    {
        public Result CriarPessoa(string nome, string cpf, string telefone)
        {

            var result = Pessoa.Criar(nome, cpf, telefone);

            if (result.IsFailure)
                return Result.Failure(result.Errors.ToList());

            var pessoa = result.Value;

            // Aqui você salvaria no banco (repository)
            // _repository.Add(pessoa);

            return Result.Success();
        }
    }

}
