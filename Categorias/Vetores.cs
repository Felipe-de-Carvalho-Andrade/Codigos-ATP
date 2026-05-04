using System;
using System.Linq;
using System.Reflection.Metadata;

namespace Exercicios.Categorias.Vetores {
    class Vetores {
        public void Menu() {
            int opcao = -1;

            do
            {
                if (!(opcao == -1)) {
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.WriteLine("\n=== EXERCÍCIOS DE VETORES E MATRIZES ===");
                Console.WriteLine("1 - Soma, Média e Comparação");
                Console.WriteLine("2 - Mega Sena");
                Console.WriteLine("3 - Contar Caracteres");
                Console.WriteLine("4 - Paridade de Vetores");
                Console.WriteLine("5 - Identificar Maior Valor");
                Console.WriteLine("6 - Processar Matriz");
                Console.WriteLine("100 - Desafio (Emendando Vetores)");
                Console.WriteLine("0 - Voltar");
                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine()!);

                Console.Clear();

                switch (opcao) {
                    case 1:
                        Exercicio01();
                        break;
                    
                    case 2:
                        MegaSena();
                        break;
                    
                    case 3:
                        ContaCaracteres();
                        break;

                    case 4:
                        Paridade();
                        break;
                    
                    case 5:
                        IdentificaMaior();
                        break;

                    case 6:
                        ProcessarMatriz();
                        break;

                    case 100:
                        Desafio();
                        break;
                }

            } while (opcao != 0);
        }

        public static void Exercicio01() {
            Console.Write("Informe a quantidade de números: ");
            int n = int.Parse(Console.ReadLine()!);
            
            int[] vet = new int[n];
            
            for (int i = 0; i < n; i++) {
                Console.Write($"Número {i+1}: ");
                vet[i] = int.Parse(Console.ReadLine()!);
            }

            int soma = vet.Sum();
            double media = (double)soma/n;

            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {media}");

            int cont = 0;

            for (int i = 0; i < vet.Length; i++)
                if (vet[i] > media)
                    cont++;

            Console.Write("Valores informados maiores que a média: " + cont);

            Console.Write("\nQual número deseja encontrar: ");
            int x = int.Parse(Console.ReadLine()!);

            cont = 0;

            for (int i = 0; i < vet.Length; i++)
                if (vet[i] == x) 
                    cont++;
            
            if (cont != 0)
                Console.WriteLine($"O número FOI encontrado no vetor e ele aparece {cont} vezes!");
            else 
                Console.WriteLine("O número NÃO foi encontrado no vetor!");
        }

        public static void MegaSena() {
            Console.WriteLine("=== INFORME OS DADOS ===");

            int n;

            // Validação da quantidade de dezenas (6 a 15)
            do {
                Console.Write("Número de dezenas apostadas (6 a 15): ");
                n = int.Parse(Console.ReadLine()!);
            } while (!(n >= 6 && n <= 15));

            int[] aposta = new int[n];
            int[] sorteio = new int[6];

            Console.WriteLine("\n=== HORA DE APOSTAR ===");

            for (int i = 0; i < n; i++) {
                int numero;
                bool repetido;

                do {
                    repetido = false;

                    Console.Write($"{i + 1}ª Dezena (1 a 60): ");
                    numero = int.Parse(Console.ReadLine()!);

                    // Verifica intervalo
                    if (numero < 1 || numero > 60) {
                        Console.WriteLine("Valor inválido! Digite entre 1 e 60.");
                        repetido = true;
                    } else {
                        // Verifica repetição
                        for (int j = 0; j < i; j++) {
                            if (aposta[j] == numero) {
                                Console.WriteLine("Número repetido! Digite outro.");
                                repetido = true;
                            }
                        }
                    }

                } while (repetido);

                aposta[i] = numero;
            }

            Console.WriteLine("\n=== HORA DO SORTEIO ===");

            for (int i = 0; i < 6; i++) {
                int numero;
                bool repetido;

                do {
                    repetido = false;

                    Console.Write($"{i + 1}ª Dezena sorteada (1 a 60): ");
                    numero = int.Parse(Console.ReadLine()!);

                    if (numero < 1 || numero > 60) {
                        Console.WriteLine("Valor inválido! Digite entre 1 e 60.");
                        repetido = true;
                    } else {
                        for (int j = 0; j < i; j++) {
                            if (sorteio[j] == numero) {
                                Console.WriteLine("Número repetido no sorteio!");
                                repetido = true;
                            }
                        }
                    }

                } while (repetido);

                sorteio[i] = numero;
            }

            Console.WriteLine("\n=== RESULTADO DA APOSTA ===");
            Console.WriteLine("Dezenas apostadas : " + string.Join(" - ", aposta));
            Console.WriteLine("Dezenas sorteadas : " + string.Join(" - ", sorteio));

            int acertos = 0;

            for (int i = 0; i < aposta.Length; i++) {
                for (int j = 0; j < sorteio.Length; j++) {
                    if (aposta[i] == sorteio[j]) {
                        acertos++;
                        j = sorteio.Length; 
                    }
                }
                if (acertos == 6) 
                    i = aposta.Length;
            }

            Console.WriteLine($"\nTotal de acertos: {acertos}");

            if (acertos == 6) {
                Console.WriteLine("\n🎉 RESULTADO: SENA!");
                Console.WriteLine("Parabéns! Você acertou todas as dezenas e ganhou o prêmio máximo!");
            }
            else if (acertos == 5) {
                Console.WriteLine("\n🥈 RESULTADO: QUINA");
                Console.WriteLine("Excelente! Você acertou 5 dezenas e ganhou um ótimo prêmio!");
            }
            else if (acertos == 4) {
                Console.WriteLine("\n🥉 RESULTADO: QUADRA");
                Console.WriteLine("Bom resultado! Você acertou 4 dezenas.");
            }
            else if (acertos > 0) {
                Console.WriteLine("\nRESULTADO: ACERTOS PARCIAIS");
                Console.WriteLine("Você acertou algumas dezenas, mas não o suficiente para premiação.");
            }
            else {
                Console.WriteLine("\nRESULTADO: NENHUM ACERTO");
                Console.WriteLine("Não houve acertos desta vez. Tente novamente!");
            }
        }

        public static void ContaCaracteres () {
            Console.Write("Digite uma frase: ");
            string s = Console.ReadLine()!.ToUpper();

            int[] contador = new int[32];
            char[] vetor = s.ToCharArray();

            for (int i = 0; i < vetor.Length; i++) 
                if (vetor[i] >= 'A' && vetor[i] <= 'Z') 
                    contador[vetor[i] - 'A']++;

            Console.WriteLine("\n=== CONTAGEM DE LETRAS ===");

            for (int i = 0; i < 26; i++) 
                if (contador[i] > 0) {
                    char letra = (char)(i + 'A');
                    Console.WriteLine($"{letra}: {contador[i]} aparições");
                }
        }

        public static void Paridade() {
            Console.WriteLine("Informe 10 números inteiros positivos");
            
            int[] vetor =  new int[10];
            int qtdPares = 0, qtdImpares = 0;
            
            for (int i = 0; i < vetor.Length; i++) {
                Console.Write($"Número {i+1}: ");
                vetor[i] = int.Parse(Console.ReadLine()!);

                if (vetor[i] % 2 == 0)
                    qtdPares++;
                else 
                    qtdImpares++;
            }

            int[] vP =  new int[qtdPares];
            int[] vI =  new int[qtdImpares];

            for (int i = 0, j = 0, k = 0; i < vetor.Length; i++) 
                if (vetor[i] % 2 == 0)
                    vP[j++] = vetor[i];
                else 
                    vI[k++] = vetor[i];

            Console.WriteLine("\n=== VALORES PARES ===");
            int soma = 0;
            for (int i = 0; i < vP.Length; i++) {
                Console.Write(vP[i] + " ");
                soma += vP[i];
            }

            double media = vP.Length > 0 ? (double)soma / vP.Length : 0;
            Console.WriteLine($"\nSoma dos pares: {soma}");
            Console.WriteLine($"Média dos pares: {media:F2}");

            Console.WriteLine("\n=== VALORES ÍMPARES ===");
            soma = 0;
            for (int i = 0; i < vI.Length; i++) {
                Console.Write(vI[i] + " ");
                soma += vI[i];
            }

            media = vI.Length > 0 ? (double)soma / vI.Length : 0;
            Console.WriteLine($"\nSoma dos ímpares: {soma}");
            Console.WriteLine($"Média dos ímpares: {media:F2}");
        }

        public static void IdentificaMaior() {
            Console.Write("Informe quantos valores serão armazenados: ");
            int q = int.Parse(Console.ReadLine()!);

            int[] vetor = new int[q];

            for (int i = 0; i < q; i++) {
                Console.Write($"Número {i + 1}: ");
                vetor[i] = int.Parse(Console.ReadLine()!);
            }

            int maior = vetor[0];
            
            for (int i = 1; i < q; i++)
                if (vetor[i] > maior)
                    maior = vetor[i];
              

            List<int> posicoes = new List<int>();

            for (int i = 0; i < q; i++)
                if (vetor[i] == maior)
                    posicoes.Add(i);

            Console.WriteLine($"\nMaior número: {maior}");
            Console.WriteLine("Posições onde ele aparece: " + string.Join(", ", posicoes));
        }
        
        public static void ProcessarMatriz() {
            Console.Write("Informe a quantidade de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine()!);

            Console.Write("Informe a quantidade de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine()!);

            int[,] matriz = new int[m, n];
            int aux = 1;

            for (int i = 0; i < matriz.GetLength(0); i++) 
                for (int j = 0; j < matriz.GetLength(1); j++) 
                    matriz[i, j] = aux++;

            int[] vSL = new int[m]; // soma das linhas
            int[] vML = new int[m]; // maior das linhas
            int[] vSC = new int[n]; // soma das colunas
            int[] vMC = new int[n]; // maior das colunas

            // Linhas
            for (int i = 0; i < matriz.GetLength(0); i++) {
                int soma = 0;
                int maior = matriz[i, 0];

                for (int j = 0; j < matriz.GetLength(1); j++) {
                    soma += matriz[i, j];

                    if (matriz[i, j] > maior)
                        maior = matriz[i, j];
                }

                vSL[i] = soma;
                vML[i] = maior;
            }   

            // Colunas
            for (int i = 0; i < matriz.GetLength(1); i++) {
                int soma = 0;
                int maior = matriz[0, i];

                for (int j = 0; j < matriz.GetLength(0); j++) {
                    soma += matriz[j, i];

                    if (matriz[j, i] > maior)
                        maior = matriz[j, i];
                }

                vSC[i] = soma;
                vMC[i] = maior;
            }

            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++)
                    Console.Write(matriz[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            Console.WriteLine("\nSoma das linhas (VSL): " + string.Join(", ", vSL));
            Console.WriteLine("Maior das linhas (VML): " + string.Join(", ", vML));
            Console.WriteLine("Soma das colunas (VSC): " + string.Join(", ", vSC));
            Console.WriteLine("Maior das colunas (VMC): " + string.Join(", ", vMC));
        }
        
        public static void Desafio () {        
            Random rnd = new Random();

            Console.Write("Tamanho do Vetor 1: ");
            int tam1 = int.Parse(Console.ReadLine()!);

            Console.Write("Tamanho do Vetor 2: ");
            int tam2 = int.Parse(Console.ReadLine()!);

            int[] v1 = new int[tam1];
            int[] v2 = new int[tam2];
            int[] v3 = new int[tam1 + tam2];

            for (int i = 0; i < v1.Length; i++)
                v1[i] = rnd.Next(1, 101);

            for (int i = 0; i < v2.Length; i++)
                v2[i] = rnd.Next(1, 101);

            for (int i = 0; i < v3.Length; i++) {
                if (i <= (v1.Length - 1))
                    v3[i] = v1[i];
                else 
                    v3[i] = v2[i - v1.Length];
            }

            Console.WriteLine("\n=== VETORES GERADOS ===");
            Console.WriteLine("V1: " + string.Join(" - ", v1));
            Console.WriteLine("V2: " + string.Join(" - ", v2));
            Console.WriteLine("V3: " + string.Join(" - ", v3));
        }

    }
}