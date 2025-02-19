namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digie um 1º Numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Digite o 2º Número ");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Digite o 3º Número ");
            int numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            int[] numeros = new int[3];
                numeros[0] = numero1;
                numeros[1] = numero2;
                numeros[2] = numero3;

            Console.Write($"O maior número é {numeros.Max()}");
        }
    }
}
