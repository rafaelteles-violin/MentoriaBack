

///SWITCH CASE

Console.WriteLine("Digite um número de 1 a 3:");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1:
        Console.WriteLine("Você escolheu o número UM.");
        break;

    case 2:
        Console.WriteLine("Você escolheu o número DOIS.");
        break;

    case 3:
        Console.WriteLine("Você escolheu o número TRÊS.");
        break;

    default:
        Console.WriteLine("Número inválido! Digite entre 1 e 3.");
        break;
}