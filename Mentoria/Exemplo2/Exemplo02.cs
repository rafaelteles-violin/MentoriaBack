using System;
using System.Net.Http;
using System.Threading.Tasks;

class Exemplo02
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();

        string url = "https://pokeapi.co/api/v2/pokemon/1";
        string conteudo = await client.GetStringAsync(url);

        Console.WriteLine("Resposta da API:");
        Console.WriteLine(conteudo);
    }
}