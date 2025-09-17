using System;
using System.Collections.Generic;
using System.Linq;

class Exemplo01
{
    static void Main(string[] args)
    {
        var numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

        var pares = numeros.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Números pares encontrados:");
        foreach (var n in pares)
        {
            Console.WriteLine(n);
        }
    }
}