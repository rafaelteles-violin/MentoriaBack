
///IF
Console.WriteLine("Digite um número: ");

string input = Console.ReadLine();

int numero = int.Parse(input);

if (numero % 2 == 0)
{
    Console.WriteLine($"{numero} é par");
}
else
{
    Console.WriteLine($"{numero} é ímpar");
}