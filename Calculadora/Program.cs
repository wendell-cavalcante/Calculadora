namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base da seleção de operação
            
            Console.WriteLine("Qual tipo de operação você quer usar? ");
            Console.WriteLine("1 - Soma ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 - Divisão\n ");

            Console.ReadLine();

            int operacao = int.Parse(Console.ReadLine());

            // Números solicitados pelo usuario

            Console.WriteLine("Digite o primerio número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            int num2 = int.Parse(Console.ReadLine());

            // Realização das operações

            int resultado;





        }
    }
}
