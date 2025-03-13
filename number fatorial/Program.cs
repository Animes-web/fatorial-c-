using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número para calcular o fatorial dele ");
        int numero = int.Parse(Console.ReadLine());

        BigInteger fatorial = 1;
        for (int i = numero; i > 1; i--)
        {
            fatorial *= i;
        }

        Console.WriteLine($"O fatorial de {numero} é {fatorial}");
    }
}
