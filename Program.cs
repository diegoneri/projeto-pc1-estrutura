using System;

namespace projeto_pc1_estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoSelecionada = -1;
            exibeMenu();

            do
            {
                opcaoSelecionada = selecionaOpcao();
                executarOpcao(opcaoSelecionada);
            } while (opcaoSelecionada != 0);
        }

        static void exibeMenu()
        {
            string menu = @"
            ================================
            | Menu de opções - Meu projeto |
            ================================
            |  1 - Soma                    |
            |  2 - Subtração               |
            |  0 - Sair                    |
            ================================
            ";
            Console.WriteLine(menu);
        }

        static int selecionaOpcao()
        {
            Console.Write("Digite sua opção: ");
            string opcaoInformada = Console.ReadLine();
            int opcao;
            bool ehNumero = Int32.TryParse(opcaoInformada, out opcao);
            if (ehNumero)
            {
                return opcao;
            }
            else
            {
                return -1;
            }
        }

        static void executarOpcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    efetuaSoma();
                    break;
                case 2:
                    Console.WriteLine("Subtração");
                    break;
                case 0:
                    Console.WriteLine("Obrigado por utilizar o programa. Apareça mais vezes!!");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
        static void efetuaSoma()
        {
            Console.Write("\nDigite um número: ");
            double numeroUm = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDigite outro número: ");
            double numeroDois = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{numeroUm} + {numeroDois} = {numeroUm + numeroDois}\n");
            Console.WriteLine($"Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
