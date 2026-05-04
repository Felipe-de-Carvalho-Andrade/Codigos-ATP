using System;

namespace Exercicios.Categorias.Repeticoes {
    class Repeticao {
        public void Menu() {
            int opcao = -1;

            do
            {
                if (!(opcao == -1)) {
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.WriteLine("\n=== EXERCÍCIOS REPETIÇÃO ===");
                Console.WriteLine("1 - Sequência de Fibonacci");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine()!);

                Console.Clear();

                switch (opcao) {
                    case 1:
                        Fibonacci();
                        break;
                }

            } while (opcao != 0);
        }
    
        public static void Fibonacci() {
            Console.Write("Informe a quantidade de termos da sequência de Fibonacci: ");
            int n = int.Parse(Console.ReadLine()!);
            int termoAnterior = 0, termoAtual = 1;

            Console.Write("\n1 - ");
            for (int i = 1; i <= n; i++) {
                int novoTermo = termoAnterior + termoAtual;
                if (i < n)
                    Console.Write($"{novoTermo} - ");
                else 
                    Console.Write($"{novoTermo}.");
                termoAnterior = termoAtual;
                termoAtual = novoTermo;
            }
        }

    }
}