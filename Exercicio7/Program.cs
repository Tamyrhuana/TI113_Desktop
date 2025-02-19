using System.Drawing;
using System.Text;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que o usuário escreva o nome e o preço de seis
            //produtos e assim que terminar de escrever o ultimo produto, mostre o
            //nome e o valor do produto mais barato.


            string[] produto = new string[6];


            Console.Write("Digite o seu 1° produto: ");
            produto[0] = Console.ReadLine()!;
            Console.Write("Digite o seu 2° produto: ");
            produto[0] = Console.ReadLine()!;
            Console.Write("Digite o seu 3° produto: ");
            produto[0] = Console.ReadLine()!;
            Console.Write("Digite o seu 4° produto: ");
            produto[0] = Console.ReadLine()!;
            Console.Write("Digite o seu 5° produto: ");
            produto[0] = Console.ReadLine()!;
            Console.Write("Digite o seu 6° produto: ");
            produto[0] = Console.ReadLine()!;



            double[] preco = new double[6];
            Console.WriteLine("Digite o 1° preço:");
            preco[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 2° preço");
            preco[1] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 3° preço");
            preco[2] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 4° preço");
            preco[3] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 5° preço");
            preco[4] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("Digite o 6° preço");
            preco[5] = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");


            Double menor = preco.Min();
            Console.WriteLine($"O menor preço é {menor}");



        }
    }
}