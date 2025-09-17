using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo04
{
    public class Exemplo04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());


            var pessoa = new Pessoa { Nome = nome, Idade = idade };
            pessoa.Apresentar();
        }
    }
}
