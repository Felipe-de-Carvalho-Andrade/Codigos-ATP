using System;

namespace Exercicios.Categorias.Iniciais {
    class Iniciais {
        public void Menu() {
            int opcao = -1;

            do
            {      
                if (!(opcao == -1)) {
                    Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                Console.WriteLine("\n=== EXERCÍCIOS INICIAIS ===");
                Console.WriteLine("1 - Calcular Herança");
                Console.WriteLine("2 - Tamanho do Terreno");
                Console.WriteLine("3 - Caixa d'água Quadrangular");
                Console.WriteLine("4 - Caixa d'água Cilíndrica");
                Console.WriteLine("5 - Emitir Contracheque");
                Console.WriteLine("6 - Exibir Taxa de Alunos Reprovados");
                Console.WriteLine("7 - Loja de Bicicletas");
                Console.WriteLine("0 - Voltar");

                Console.Write("Escolha: ");
                opcao = int.Parse(Console.ReadLine()!);

                Console.Clear();

                switch (opcao) {
                    case 1:
                        CalculaHeranca();
                        break;

                    case 2:
                        TamanhoTerreno();
                        break;

                    case 3:
                        CaixaQuadrangular();
                        break;

                    case 4:
                        CaixaCilindrica();
                        break;

                    case 5:
                        Holerite();
                        break;

                    case 6:
                        TaxaReprovacao();
                        break;
                    
                    case 7:
                        LojaBicicletas();
                        break;
                }

            } while (opcao != 0);
        }

        public void CalculaHeranca() {
            Console.Write("Informe o valor da herança: ");
            double heranca = double.Parse(Console.ReadLine()!);

            Console.Write("Informe a idade do primeiro irmão: ");
            int idadeA = int.Parse(Console.ReadLine()!);

            Console.Write("Informe a idade do segundo irmão: ");
            int idadeB = int.Parse(Console.ReadLine()!);

            Console.Write("Informe a idade do terceiro irmão: ");
            int idadeC = int.Parse(Console.ReadLine()!);

            int soma = idadeA + idadeB + idadeC;
            double cota = heranca / soma;

            Console.WriteLine($"O irmão com {idadeA} anos de idade receberá: {(cota * idadeA):F2}");
            Console.WriteLine($"O irmão com {idadeB} anos de idade receberá: {(cota * idadeB):F2}");
            Console.WriteLine($"O irmão com {idadeC} anos de idade receberá: {(cota * idadeC):F2}");
        }

        public void TamanhoTerreno() {
            Console.Write("Comprimento do arame (m): ");
            double arame = double.Parse(Console.ReadLine()!);

            double lado = arame / 4;

            Console.WriteLine($"Lado do terreno: {lado} m");
            Console.WriteLine($"Área: {lado * lado} m²");
        }

        public void CaixaQuadrangular() {
            Console.WriteLine("Informe as seguintes medidas da Caixa d'água");
            Console.Write("Comprimento: ");
            double c = double.Parse(Console.ReadLine()!);

            Console.Write("Largura: ");
            double l = double.Parse(Console.ReadLine()!);

            Console.Write("Altura: ");
            double h = double.Parse(Console.ReadLine()!);

            double volume = c * l * h;

            Console.WriteLine($"Volume: {volume} m³");
        }

        public void CaixaCilindrica() {
            Console.WriteLine("Informe as seguintes medidas da Caixa d'água");
            Console.Write("Raio: ");
            double r = double.Parse(Console.ReadLine()!);

            Console.Write("Altura: ");
            double h = double.Parse(Console.ReadLine()!);

            double areaBase = Math.PI * Math.Pow(r, 2);
            double volume = areaBase * h;

            Console.WriteLine($"Área da base: {areaBase:F2}");
            Console.WriteLine($"Volume: {volume:F2}");
        }

        public void Holerite () {
            Console.Write("Informe o salário do funcionário: ");
            double salarioBruto = double.Parse(Console.ReadLine()!);

            Console.Write("Informe o percentual de desconto do INSS: ");    
            double descINSS = double.Parse(Console.ReadLine()!);

            Console.Write("Informe o percentual de desconto do IRRF: ");
            double descIRRF = double.Parse(Console.ReadLine()!);

            double valDescINSS = (descINSS / 100) * salarioBruto;
            double valDescIRRF = (descIRRF / 100) * salarioBruto;
            double salarioLiquido =  salarioBruto - (valDescINSS  + valDescIRRF);

            Console.WriteLine($"Salário Bruto: {salarioBruto}");
            Console.WriteLine($"Desconto do INSS: {descINSS}");
            Console.WriteLine($"Desconto do IRRF: {descIRRF}");
            Console.WriteLine($"Salário Líquido: {salarioLiquido}");
        }

        public void TaxaReprovacao()  {
            Console.Write("Quantos alunos foram aprovados na turma A: ");
            int qtdA = int.Parse(Console.ReadLine()!);

            Console.Write("Quantos alunos foram aprovados na turma B: ");
            int qtdB = int.Parse(Console.ReadLine()!);

            int totalA = 60;
            int totalB = 40;

            double percentualReprovadosA = ((totalA - qtdA) * 100.0) / totalA;
            double percentualReprovadosB = ((totalB - qtdB) * 100.0) / totalB;
            double percentualGeral = (((totalA - qtdA) + (totalB - qtdB)) * 100.0) / (totalA + totalB);

            Console.WriteLine($"Percentual de Alunos Reprovados na Turma A: {percentualReprovadosA:F2}%");
            Console.WriteLine($"Percentual de Alunos Reprovados na Turma B: {percentualReprovadosB:F2}%");
            Console.WriteLine($"Percentual Geral: {percentualGeral:F2}%");
        }
        
        public void LojaBicicletas() {
            Console.WriteLine("Informe os seguintes dados sobre a loja\n");

            Console.Write("Quantidade de empregados da loja: ");
            int qtdEmpregados =  int.Parse(Console.ReadLine()!);

            Console.Write("Salário mínimo (R$): ");
            double salarioMinimo = double.Parse(Console.ReadLine()!);

            Console.Write("Preço de custo da bicicleta (R$): ");
            double precoCusto = double.Parse(Console.ReadLine()!);

            Console.Write("Quantidade de bicicletas vendidas: ");
            int qtdVendidas = int.Parse(Console.ReadLine()!);

            double precoVenda = precoCusto * 1.5;
            double receitaTotal = precoVenda * qtdVendidas;

            double comissaoTotal = precoVenda * 0.15 * qtdVendidas;
            double comissaoPorEmpregado = comissaoTotal / qtdEmpregados;

            double salarioBase = salarioMinimo * 2;
            double salarioFinal = salarioBase + comissaoPorEmpregado;

            // Gastos Finais 
            double custoSalarios = salarioFinal * qtdEmpregados;
            double custoEstoque = precoCusto * qtdVendidas;

            // Lucro ou Prejuízo
            double lucro = receitaTotal - (custoSalarios + custoEstoque);

            Console.WriteLine("\n=== RESULTADOS ===\n");
            Console.WriteLine($"Preço de venda por bicicleta: R$ {precoVenda:F2}");
            Console.WriteLine($"Receita total: R$ {receitaTotal:F2}");
            Console.WriteLine($"Custo com salários: R$ {custoSalarios:F2}");
            Console.WriteLine($"Custo com estoque: R$ {custoEstoque:F2}");

            Console.WriteLine($"\nSalário final por empregado: R$ {salarioFinal:F2}");

            if (lucro >= 0)
                Console.WriteLine($"\nResultado: LUCRO de R$ {lucro:F2}");
            else
                Console.WriteLine($"\nResultado: PREJUÍZO de R$ {lucro:F2}");
        }
    }
}