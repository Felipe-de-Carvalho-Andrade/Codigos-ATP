using System;
using System.Linq;

namespace Exercicios.Categorias.Condicionais {
    class Condicionais {
        public void Menu() {
            int opcao = -1;

            do
            {
                if (!(opcao == -1)) {
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.WriteLine("\n=== EXERCÍCIOS CONDICIONAIS ===");
                Console.WriteLine("1 - Eleição");
                Console.WriteLine("2 - Caixa Eletrônico");
                Console.WriteLine("3 - Abastecer Veículo");
                Console.WriteLine("4 - Propriedades dos Números");
                Console.WriteLine("5 - Equação Polinomial de Grau 2");
                Console.WriteLine("6 - Validação do Grafo");
                Console.WriteLine("0 - Voltar");

                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine()!);

                Console.Clear();

                switch (opcao) {
                    case 1:
                        Eleicao();
                        break;

                    case 2:
                        CaixaEletronico();
                        break;
                    
                    case 3:
                        AbastecerVeiculo();
                        break;
                    
                    case 4:
                        Numeros();
                        break;

                    case 5:
                        EquacaoGrau2();
                        break;

                    case 6:
                        VerificaGrafo();
                        break;
                }

            } while (opcao != 0);
        }

        public void Eleicao () {
            int[] votos = new int[3];
            int[] idade = new int[3];

            for (int i = 0; i < 3; i++) {
                Console.Write($"Digite o número de votos do candidato {i + 1}: ");
                votos[i] = int.Parse(Console.ReadLine()!);

                Console.Write($"Digite a idade do candidato {i + 1}: ");
                idade[i] = int.Parse(Console.ReadLine()!);
            }

            int maxVotos = Math.Max(votos[0], Math.Max(votos[1], votos[2]));

            int[] indicesVencedores = Array.FindAll(
                new int[] { 0, 1, 2 },
                i => votos[i] == maxVotos
            );

            if (indicesVencedores.Length == 1) {
                Console.WriteLine($"O vencedor é o candidato {indicesVencedores[0] + 1}!");
            } else {
                int maiorIdade = idade[indicesVencedores[0]];
                int vencedor = indicesVencedores[0];
                bool empateTotal = false;

                for (int i = 1; i < indicesVencedores.Length; i++) {
                    int aux = indicesVencedores[i];

                    if (idade[aux] > maiorIdade) {
                        maiorIdade = idade[aux];
                        vencedor = aux;
                        empateTotal = false; 
                    } else if (idade[aux] == maiorIdade) {
                        empateTotal = true; 
                    }
                }

                if (empateTotal) {
                    Console.WriteLine("Empate total! Uma nova eleição deve ser realizada.");
                } else {
                    Console.WriteLine($"O vencedor é o candidato {vencedor + 1}!");
                }
            }
        }

        public void CaixaEletronico() {
            double saldo, valor = 0;
            int operacao;
            bool loop = true;

            Console.Write("Digite o saldo atual da conta: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("\nEscolha a operação:");
                Console.WriteLine("1 - Saque");
                Console.WriteLine("2 - Depósito");
                Console.WriteLine("3 - Pagamento de Conta");
                Console.WriteLine("4 - Transferência");
                Console.WriteLine("5 - Saldo da Conta");
                Console.WriteLine("0 - Encerrar Sessão");
                Console.Write("Opção: ");
                operacao = Convert.ToInt32(Console.ReadLine());

                if (operacao == 0) continue; 
                else if (!(operacao == 5)) {
                    Console.Write("Digite o valor da operação: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                } 

                switch (operacao) {
                    case 1: // Saque
                    case 3: // Pagamento
                    case 4: // Transferência
                        saldo -= valor;
                        break;

                    case 2: // Depósito
                        saldo += valor;
                        break;

                    case 5: // Ver Saldo
                        Console.WriteLine("\nSaldo final da conta: R$ " + saldo);
                        break;

                    case 0:
                        Console.WriteLine("\nEncerrando Sessão...");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        return;
                }
            } while (loop);
        }

        public void AbastecerVeiculo() {
            double litros, precoLitro;
            double valorTotal, valorPagar, desconto = 0;
            double percentual = 0;

            Console.Write("Digite a quantidade de litros abastecidos: ");
            litros = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o preço do litro do combustível: ");
            precoLitro = Convert.ToDouble(Console.ReadLine());

            valorTotal = litros * precoLitro;
            
            if (litros >= 10 && litros <= 30)
                percentual = 0.01;
            else if (litros > 30 && litros < 40)
                percentual = 0.02;
            else if (litros >= 40) 
                percentual = 0.025;

            desconto = valorTotal * percentual;
            valorPagar = valorTotal - desconto;

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine($"Litros abastecidos: {litros:F2}");
            Console.WriteLine($"Preço por litro: R$ {precoLitro:F2}");
            Console.WriteLine($"Valor total: R$ {valorTotal:F2}");
            Console.WriteLine($"Desconto: R$ {desconto:F2}");
            Console.WriteLine($"Valor a pagar: R$ {valorPagar:F2}");
        }

        public void Numeros() {
            int[] numeros = new int[4];

            int soma = 0;
            int maior = int.MinValue;
            int menor = int.MaxValue;

            int pares = 0, impares = 0;
            int positivos = 0, negativos = 0, nulos = 0;

            for (int i = 0; i < 4; i++) {
                Console.Write("Digite um número inteiro: ");
                numeros[i] = int.Parse(Console.ReadLine()!);

                int n = numeros[i];

                soma += n;

                if (n > maior) maior = n;
                if (n < menor) menor = n;

                if (n % 2 == 0) pares++;
                else impares++;

                if (n > 0) positivos++;
                else if (n < 0) negativos++;
                else nulos++;
            }

            double media = (double) soma / 4;

            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Maior número: {maior}");
            Console.WriteLine($"Menor número: {menor}");
            Console.WriteLine($"Quantidade de pares: {pares}");
            Console.WriteLine($"Quantidade de ímpares: {impares}");
            Console.WriteLine($"Quantidade de positivos: {positivos}");
            Console.WriteLine($"Quantidade de negativos: {negativos}");
            Console.WriteLine($"Quantidade de nulos (zero): {nulos}");
        }

        public void EquacaoGrau2() {
            double a, b, c;

            Console.Write("Informe o valor do coeficiente 'a': ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do coeficiente 'b': ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor do coeficiente 'c': ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0) {
                Console.WriteLine("Não é uma equação do segundo grau!");
                return;
            }

            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0) {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"As raízes reais são: {x1} e {x2}");
            } else if (delta == 0) {
                double x = (-b) / (2 * a);

                Console.WriteLine($"Há apenas uma raiz real: {x}");
            } else {
                Console.WriteLine("Não existem raízes reais.");
            }
        }

        public void VerificaGrafo() {
            int vertices, arestas;

            Console.Write("Informe o número de vértices do grafo: ");
            vertices = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o número de arestas do grafo: ");
            arestas = Convert.ToInt32(Console.ReadLine());

            int maxArestas = vertices * (vertices - 1) / 2;
            int minArestas = 0;

            if (arestas < minArestas || arestas > maxArestas) {
                Console.WriteLine($"Número de arestas inválido para um grafo com {vertices} vértices.");
            } else {
                Console.WriteLine("Número de arestas válido.");

                if (arestas == maxArestas) {
                    Console.WriteLine("O grafo é completo.");
                } else {
                    Console.WriteLine("O grafo não é completo.");
                }
            }

        }

    }
}