using System;
using Microsoft.Extensions.DependencyInjection;

public interface IServico
{
    void Executar();
}

public class Servico : IServico
{
    public void Executar()
    {
        Console.WriteLine("Serviço executado com sucesso!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando o container de serviços
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<IServico, Servico>();

        var provider = serviceCollection.BuildServiceProvider();

        // Resolvendo a dependência
        var servico = provider.GetRequiredService<IServico>();
        servico.Executar();
    }
}