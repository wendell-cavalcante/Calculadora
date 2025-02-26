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

            // Exibição das Função

            if (operacao == 1) Console.WriteLine($"Função SOMA ");
            if (operacao == 2) Console.WriteLine($"Função SUBTRAÇÃO ");
            if (operacao == 3) Console.WriteLine($"Função MULTIPLICAÇÃO ");
            if (operacao == 4) Console.WriteLine($"Função DIVISÃO ");


            // Números solicitados pelo usuario

            Console.Write("Digite o primerio número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            // Realização das operações

            int resultado;

            switch (operacao)
            {
                case 2:
                    {
                        resultado = num1 - num2;
                        Console.WriteLine($"Seu resultado é: {resultado}");
                    }
                    break;
            }

            switch (operacao)
            {
                case 4:
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Seu resultado é: {resultado}");
                    }
                    break;
            }






        }
    }
}
