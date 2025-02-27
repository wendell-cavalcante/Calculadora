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

            // Exibição das Função // Opção Inválida

            if (operacao == 1) Console.WriteLine($"\nFunção SOMA \n");
            if (operacao == 2) Console.WriteLine($"\nFunção SUBTRAÇÃO \n");
            if (operacao == 3) Console.WriteLine($"\nFunção MULTIPLICAÇÃO \n");
            if (operacao == 4) Console.WriteLine($"\nFunção DIVISÃO \n");
            if (operacao > 4 || operacao < 1)
            {
                Console.WriteLine("Opção inválida");
                return;
            }


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
            
     
                case 2:
                    {
                        resultado = num1 - num2;
                        Console.WriteLine($"Seu resultado é: {resultado}");
                    }
                    break;
          
                case 3:
                    {
                        resultado = num1 * num2;
                        Console.WriteLine($"Seu resultado é: {resultado}");
                    }
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("Resultado da divisão: " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("Erro! Divisão por zero não permitida.");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
        }







    }
}

