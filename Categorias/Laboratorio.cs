using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercicios.Categorias.Laboratorio {
    class Laboratório {
        public void Menu() {
            int opcao = -1;

            do
            {
                if (!(opcao == -1)) {
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.WriteLine("\n=== EXERCÍCIOS LABORATÓRIO ===");
                Console.WriteLine("1 - Verificar Sinal de um Número");
                Console.WriteLine("2 - Verificar Paridade de um Número");
                Console.WriteLine("3 - Classificar Faixa Etária");
                Console.WriteLine("4 - Calcular Salário com Horas Extras");
                Console.WriteLine("5 - Obter Dia da Semana");
                Console.WriteLine("6 - Obter Mês do Ano");
                Console.WriteLine("7 - Converter Temperaturas entre Escalas");
                Console.WriteLine("8 - Calcular Média de Idade da Turma");
                Console.WriteLine("9 - Analisar Conjunto de Valores");
                Console.WriteLine("10 - Sequência de Pares e Ímpares");
                Console.WriteLine("11 - Verificar Número Primo");
                Console.WriteLine("12 - Pontuação de Campeonato");
                Console.WriteLine("0 - Voltar");

                Console.Write("\nEscolha: ");
                opcao = int.Parse(Console.ReadLine()!);

                Console.Clear();

                switch (opcao) {
                    case 1:
                        VerificarSinal();
                        break;

                    case 2:
                        VerificarParidade();
                        break;

                    case 3:
                        ClassificarFaixaEtaria();
                        break;

                    case 4:
                        CalcularSalarioFinal();
                        break;

                    case 5:
                        ObterDiaSemana();
                        break;

                    case 6:
                        ObterMes();
                        break;

                    case 7:
                        ConverteTemperatura();
                        break;
                    
                    case 8:
                        MediaIdade();
                        break;

                    case 9:
                        AnalisarValores();
                        break;

                    case 10:
                        GerarSequenciaParesImpares();
                        break;
                    
                    case 11:
                        IsPrime();
                        break;
                    
                    case 12:
                        Campeonato();
                        break;
                }

            } while (opcao != 0);
        }

        public static void VerificarSinal() {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero > 0)
                Console.WriteLine("O número informado é positivo");
            else if (numero < 0)
                Console.WriteLine("O número informado é negativo");
            else 
                Console.WriteLine("O número informado é um número nulo, ou seja, 0");
        }

        public static void VerificarParidade() {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero % 2 == 0) 
                Console.WriteLine("O número informado é PAR");
            else 
                Console.WriteLine("O número informado é ÍMPAR");
        }

        public static void ClassificarFaixaEtaria() {
            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine()!);

            if (idade >= 0 && idade <= 17) 
                Console.WriteLine("Você é MENOR de idade!");
            else if (idade <= 64)
                Console.WriteLine("Você é MAIOR de idade!");
            else if (idade >= 65)
                Console.WriteLine("Você é uma pessoa IDOSA");
            else
                Console.WriteLine("Idade INVÁLIDA!");
        }

        public static void CalcularSalarioFinal() {
            Console.WriteLine("=== INFORME OS DADOS DO EMPREGADO ===");

            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine()!);

            Console.Write("Horas Extras Realizadas: ");
            int qtdHorasExtras = int.Parse(Console.ReadLine()!);

            double salarioFinal = salarioBase;;

            if (qtdHorasExtras >= 1 && qtdHorasExtras <= 10) {
                salarioFinal += salarioBase * 0.01 * qtdHorasExtras;
            } else if (qtdHorasExtras >= 11 && qtdHorasExtras <= 20) {
                salarioFinal += salarioBase * 0.02 * qtdHorasExtras;
            } else if (qtdHorasExtras >= 20) {
                salarioFinal += salarioBase * 0.03 * qtdHorasExtras;
            } else {
                Console.WriteLine($"O rendimento total do empregado: R$ {salarioFinal:F2}");
                return;
            }

            Console.WriteLine($"O rendimento total do empregado: R$ {salarioFinal:F2}");
        }

        public static void ObterDiaSemana() {
            Console.WriteLine("1 - Domingo\n2 - Segunda-Feira\n3 - Terça-Feira\n4 - Quarta-feira\n"
                    + "5 - Quinta-Feira\n6 - Sexta-Feira\n7 - Sábado");

            Console.Write("Informe um valor: ");
            switch(int.Parse((Console.ReadLine()!))) {
                case 1:
                    Console.WriteLine("Esse número corresponde ao Domingo");
                    break;

                case 2:
                    Console.WriteLine("Esse número corresponde a Segunda-Feira");
                    break;

                case 3:
                    Console.WriteLine("Esse número corresponde a Terça-Feira");
                    break;

                case 4:
                    Console.WriteLine("Esse número corresponde a Quarta-Feira");
                    break;

                case 5:
                    Console.WriteLine("Esse número corresponde a Quinta-Feira");
                    break;

                case 6:
                    Console.WriteLine("Esse número corresponde a Sexta-Feira");
                    break; 

                case 7:
                    Console.WriteLine("Esse número corresponde ao Sábado");
                    break;  

                default:
                    Console.WriteLine("Dia Inválido!!!");
                    break;
            }
        }

        public static void ObterMes() {
            Console.Write("Informe um valor inteiro entre 1 e 12: ");
            switch(int.Parse((Console.ReadLine()!))) {
                case 1:
                    Console.WriteLine("Esse número corresponde ao mês de Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Esse número corresponde ao mês de Fevereiro");
                    break;

                case 3:
                    Console.WriteLine("Esse número corresponde ao mês de Março");
                    break;

                case 4:
                    Console.WriteLine("Esse número corresponde ao mês de Abril");
                    break;

                case 5:
                    Console.WriteLine("Esse número corresponde ao mês de Maio");
                    break;

                case 6:
                    Console.WriteLine("Esse número corresponde ao mês de Junho");
                    break; 

                case 7:
                    Console.WriteLine("Esse número corresponde ao mês de Julho");
                    break;  
                
                case 8:
                    Console.WriteLine("Esse número corresponde ao mês de Agosto");
                    break;  

                case 9:
                    Console.WriteLine("Esse número corresponde ao mês de Setembro");
                    break;  

                case 10:
                    Console.WriteLine("Esse número corresponde ao mês de Outubro");
                    break;  

                case 11:
                    Console.WriteLine("Esse número corresponde ao mês de Novembro");
                    break;  

                case 12:
                    Console.WriteLine("Esse número corresponde ao mês de Dezembro");
                    break;  

                default:
                    Console.WriteLine("Mês Inválido!!!");
                    break;
            }
        }
    
        public static void ConverteTemperatura() {
            double celsius, fahrenheit, kelvin;

            Console.WriteLine("=== INFORME O TIPO DE CONVERSÃO ===\n");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Celsius para Kelvin");
            Console.WriteLine("3 - Fahrenheit para Celsius");
            Console.WriteLine("4 - Fahrenheit para Kelvin");
            Console.WriteLine("5 - Kelvin para Celsius");
            Console.WriteLine("6 - Kelvin para Fahrenheit");
            
            Console.Write("\nEscolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao) {
                case 1: // Celsius -> Fahrenheit
                    Console.Write("Digite a temperatura em ºC: ");
                    celsius = double.Parse(Console.ReadLine()!);
                    fahrenheit = (celsius * 1.8) + 32;
                    Console.WriteLine($"Temperatura em ºF: {fahrenheit:F2}");
                    break;

                case 2: // Celsius -> Kelvin
                    Console.Write("Digite a temperatura em ºC: ");
                    celsius = double.Parse(Console.ReadLine()!);
                    kelvin = celsius + 273.15;
                    Console.WriteLine($"Temperatura em K: {kelvin:F2}");
                    break;

                case 3: // Fahrenheit -> Celsius
                    Console.Write("Digite a temperatura em ºF: ");
                    fahrenheit = double.Parse(Console.ReadLine()!);
                    celsius = (fahrenheit - 32) / 1.8;
                    Console.WriteLine($"Temperatura em ºC: {celsius:F2}");
                    break;

                case 4: // Fahrenheit -> Kelvin
                    Console.Write("Digite a temperatura em ºF: ");
                    fahrenheit = double.Parse(Console.ReadLine()!);
                    kelvin = (fahrenheit - 32) / 1.8 + 273.15;
                    Console.WriteLine($"Temperatura em K: {kelvin:F2}");
                    break;

                case 5: // Kelvin -> Celsius
                    Console.Write("Digite a temperatura em K: ");
                    kelvin = double.Parse(Console.ReadLine()!);
                    celsius = kelvin - 273.15;
                    Console.WriteLine($"Temperatura em ºC: {celsius:F2}");
                    break;

                case 6: // Kelvin -> Fahrenheit
                    Console.Write("Digite a temperatura em K: ");
                    kelvin = double.Parse(Console.ReadLine()!);
                    fahrenheit = (kelvin - 273.15) * 1.8 + 32;
                    Console.WriteLine($"Temperatura em ºF: {fahrenheit:F2}");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Conversão impossível.");
                    break;
            }
        }

        public static void MediaIdade() {
            Console.WriteLine("=== INFORME OS DADOS DA TURMA ===");
            Console.Write("Quantidade de alunos: ");

            int qtdAlunos = int.Parse(Console.ReadLine()!);
            int soma = 0;

            Console.WriteLine($"=== Informe a idade dos {qtdAlunos} alunos ===");

            for (int i = 1; i <= qtdAlunos; i++) {
                Console.Write($"Aluno {i}: ");
                soma += int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("\nA média de idade dos alunos é de " + (soma/qtdAlunos) + " anos.");
        }

        public static void AnalisarValores() {
            Console.Write("Quantos valores inteiros deseja ler: ");
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Informe os valor abaixo:");
            int soma = 0, qtdPares = 0, qtdImpares = 0, qtdPositivios = 0, qtdNegativos = 0, qtdNulos = 0;
            int menor = int.MaxValue;
            int maior = int.MinValue;

            for (int i = 1; i <= n; i++) {
                Console.Write($"Valor {i}: ");
                int numero = int.Parse(Console.ReadLine()!);
                soma += numero;
                
                if (numero < menor) 
                    menor = numero;
                if (numero > maior)
                    maior = numero;
                
                if (!(numero % 2 == 0))
                    qtdImpares++;
                else 
                    qtdPares++;

                if (numero > 0)
                    qtdPositivios++;
                else if (numero < 0)
                    qtdNegativos++;
                else              
                    qtdNulos++;
            }

            Console.WriteLine("=== RESULTADOS ===");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Média: {soma/n}");
            Console.WriteLine($"Maior: {maior}");
            Console.WriteLine($"Menor: {menor}");
            Console.WriteLine($"Quantidade de Pares: {qtdPares}");
            Console.WriteLine($"Quantidade de Ímpares: {qtdImpares}");
            Console.WriteLine($"Quantidade de Positivo: {qtdPositivios}");
            Console.WriteLine($"Quantidade de Negativos: {qtdNegativos}");
            Console.WriteLine($"Quantidade de Nulos: {qtdNulos}");
        }

        public static void GerarSequenciaParesImpares() {
            Console.WriteLine("=== INFORME UM NÚMERO INTEIRO ATÉ QUE A QUANTIDADE DE PARES SEJA"
            + " O DOBRO DE ÍMPARES ===");

            int qtdPares = 0;
            int qtdImpares = 0;
            int count = 1;
             
            do
            {   
                Console.Write($"Número {count}: ");
                int numero =  int.Parse(Console.ReadLine()!);

                if (numero % 2 == 0)
                    qtdPares++;
                else if (numero % 2 == 1)
                    qtdImpares++;
                else 
                    Console.WriteLine("Número Inválido!");
                
                count++;
            } while (!(qtdPares == (qtdImpares * 2)));
        }
        
        public static void IsPrime() {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine()!);

            for (int i = 2; i <= (n/2); i++) // n/2 a metade de um número é o maior número possível que divide n
                if (n % i == 0) {
                    Console.WriteLine("O número NÃO é primo!");
                    return;
                }

            Console.WriteLine("O número é PRIMO!");
        }

        public static void Campeonato() {
            Console.WriteLine("=== INFORME OS DADOS ABAIXO ===");
            Console.Write("Quantidade de Jogos: ");
            int qtdJogos = int.Parse(Console.ReadLine()!);
            int qtdPontos = 0;
            
            Console.WriteLine("\n== INFORME OS RESULTADOS ==");
            Console.WriteLine("V - Vitória\nE - Empate\nD - Derrota\n");

            for (int i = 1; i <= qtdJogos; i++) {
                Console.Write($"Jogo {i}: ");
                string resultado = Console.ReadLine()!.ToUpper();
                
                if (resultado == "V")
                    qtdPontos += 3;
                else if (resultado == "E")
                    qtdPontos += 1;
            }
            
            double percentual = (double) (qtdPontos / (qtdJogos * 3)) * 100;

            Console.WriteLine($"Pontuação Final: {qtdPontos} pontos");
            Console.WriteLine($"Aproveitamento Percentual: {percentual:F2}%");
            if (percentual <= 50)
                Console.WriteLine("Sua Pontuação foi BAIXA!");
            else if (percentual <= 75)
                Console.WriteLine("Sua Pontuação foi BOA!");
            else 
                Console.WriteLine("Sua Pontuação foi ÓTIMA!");
        }
    }    
}