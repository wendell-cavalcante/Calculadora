namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuarCalculando = true;
            do
            {
                // Base da seleção de operação

                Console.WriteLine("Qual tipo de operação você quer usar?\n ");
                Console.WriteLine("1 - Soma ");
                Console.WriteLine("2 - Subtração ");
                Console.WriteLine("3 - Multiplicação ");
                Console.WriteLine("4 - Divisão\n ");

                double operacao = double.Parse(Console.ReadLine());

                // Opção Inválida

                while (operacao > 4 || operacao < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida, escolha uma opção válida:\n ");
                    Console.WriteLine("1 - Soma ");
                    Console.WriteLine("2 - Subtração ");
                    Console.WriteLine("3 - Multiplicação ");
                    Console.WriteLine("4 - Divisão\n ");
                    operacao = double.Parse(Console.ReadLine());
                    Console.Clear();

                }

                // Exibição da função que vai usar

                if (operacao == 1) Console.WriteLine($"\nFunção SOMA \n");
                if (operacao == 2) Console.WriteLine($"\nFunção SUBTRAÇÃO \n");
                if (operacao == 3) Console.WriteLine($"\nFunção MULTIPLICAÇÃO \n");
                if (operacao == 4) Console.WriteLine($"\nFunção DIVISÃO \n");

                // Números solicitados pelo usuario

                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                // Realização das operações

                double resultado;

                switch (operacao)
                {
                    case 1:
                        {
                            resultado = num1 + num2;
                            Console.WriteLine($"\nSeu resultado é: {resultado}");
                        }
                        break;

                    case 2:
                        {
                            resultado = num1 - num2;
                            Console.WriteLine($"\nSeu resultado é: {resultado}");
                        }
                        break;

                    case 3:
                        {
                            resultado = num1 * num2;
                            Console.WriteLine($"\nSeu resultado é: {resultado}");
                        }
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("\nResultado da divisão: " + resultado);
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

                string resposta;
                bool entradaInvalida = false;
                do

                {
                    Console.WriteLine("Deseja continuar calculando? Sim/Não");
                    resposta = Console.ReadLine();
                    if (resposta.ToLower() == "sim" || resposta.ToLower() == "não")
                        
                    {
                        entradaInvalida = true;
                    }
                    else
                    {
                        Console.WriteLine("Entrada Inválida. Digite 'Sim' ou 'Não'");
                    }

                    Console.Clear();

                } while (!entradaInvalida);

                if (resposta.ToLower() == "não")
                {
                    continuarCalculando = false;
                }

            } while (continuarCalculando);
            Console.WriteLine("Calculadora encerrada, obrigado por usar.");
        }
    }
}