﻿namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digie um 1º Numero");
            int numero1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("\n");
            Console.Write("Digite o 2º Número ");
            int numero2 = Convert.ToInt32 (Console.ReadLine());

            Console.Write("\n");
            Console.Write($"O maior número é {Math.Max(numero1, numero2)}");

        }
    }
}
