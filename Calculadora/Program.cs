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

            int operacao = int.Parse(Console.ReadLine());

            if (operacao == 1) Console.WriteLine($"Função selecionada soma ");
            
                

            // Números solicitados pelo usuario

            Console.Write("Digite o primerio número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            // Realização das operações

            int resultado;

            switch (operacao)
            {
                case 1:
                    {
                        resultado = num1 + num2;
                        Console.WriteLine($"Seu resultado é: {resultado}");
                    }
                    break;
            }






        }
    }
}
