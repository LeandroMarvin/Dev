using System;

class Program
{

    /*
Resumo dos conceitos e sintaxes aprendidas neste arquivo C#

1. Estrutura básica do programa em C#
   - O ponto de entrada é o método estático `Main()`.
   - Os métodos auxiliares são criados como métodos estáticos na mesma classe.

2. Entrada de dados segura com TryParse
   - `int.TryParse(string, out int)` e `float.TryParse(string, out float)` convertem string para número.
   - Retornam `true` se a conversão foi bem-sucedida e `false` se não.
   - Usar em loops para garantir que o usuário digite um valor válido.
   Exemplo:
       while (!int.TryParse(Console.ReadLine(), out idade)) { ... }

3. Interpolação de strings com `$`
   - Facilita inserir variáveis e expressões dentro de strings.
   - Colocar `$` antes da string e usar `{variavel}` dentro dela.
   Exemplo:
       Console.WriteLine($"A área é {area}");

4. Uso do Console
   - `Console.WriteLine()` imprime texto e pula linha.
   - `Console.Write()` imprime texto sem pular linha.
   - `Console.ReadLine()` lê entrada do usuário como string.

5. Controle de fluxo
   - `if`, `else if`, `else` para decisões condicionais.
   - `while` para laços (loops) que repetem enquanto a condição for verdadeira.

6. Vetores (arrays)
   - Declaração: `int[] vetor = new int[1000];`
   - Acessar elementos: `vetor[i]`
   - Percorrer com laços `for`.

7. Ordenação manual (Bubble Sort)
   - Algoritmo simples que compara elementos vizinhos e troca para ordenar.
   - Exemplo no método `Exercicio06_BubbleSort`.

8. Função pronta de ordenação
   - `Array.Sort(vetor)` ordena o array rapidamente.

9. Estrutura do menu interativo
   - Uso do `while` para manter o programa ativo.
   - `switch` para escolher o exercício a executar com base na entrada do usuário.
   - Uso de `Console.Clear()` para limpar a tela e deixar visual organizado.

10. Manipulação da sequência Fibonacci
    - Uso de variáveis temporárias para calcular o próximo número.
    - Impressão formatada em sequência na mesma linha.

11. Tratamento de possíveis valores nulos
    - `Console.ReadLine()` pode retornar `null`.
    - Usar operador `??` para atribuir valor padrão e evitar erros, ex:
      `string opcao = Console.ReadLine() ?? "";`
*/

    static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("=== Menu de Exercícios ===");
            Console.WriteLine("1 - Exercício 01 (Área do Retângulo)");
            Console.WriteLine("2 - Exercício 02 (Conversão Monetária)");
            Console.WriteLine("3 - Exercício 03 (Maior e Menor Número)");
            Console.WriteLine("4 - Exercício 04 (Classificação por Idade)");
            Console.WriteLine("5 - Exercício 05 (Sequência Fibonacci)");
            Console.WriteLine("6 - Exercício 06 Bubble Sort (Ordenação Manual)");
            Console.WriteLine("7 - Exercício 06 Função Sort (Ordenação com Array.Sort)");
            Console.WriteLine("8 - Resumo dos conceitos aprendidos");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine() ?? "";

            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Exercicio01();
                    break;
                case "2":
                    Exercicio02();
                    break;
                case "3":
                    Exercicio03();
                    break;
                case "4":
                    Exercicio04();
                    break;
                case "5":
                    Exercicio05();
                    break;
                case "6":
                    Exercicio06_BubbleSort();
                    break;
                case "7":
                    Exercicio06_FuncaoSort();
                    break;
                case "8":
                    ExibirResumo();
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (!sair)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }

        static void Exercicio01()
        {
            float altura, largura;

            Console.Write("Digite a altura do retângulo: ");
            while (!float.TryParse(Console.ReadLine(), out altura))
            {
                Console.Write("Valor inválido! Digite novamente a altura: ");
            }

            Console.Write("Digite a largura do retângulo: ");
            while (!float.TryParse(Console.ReadLine(), out largura))
            {
                Console.Write("Valor inválido! Digite novamente a largura: ");
            }

            float area = altura * largura;
            Console.WriteLine($"A área do retângulo é: {area}");
        }
        static void Exercicio02()
        {
            // Exercício 2: Conversão Monetária com TryParse seguro

            float valorReal;

            Console.Write("Digite o valor em reais (R$): ");
            while (!float.TryParse(Console.ReadLine(), out valorReal))
            {
                Console.Write("Valor inválido! Digite novamente: ");
            }

            float dolar = valorReal / 5.17f;
            float euro = valorReal / 6.14f;
            float pesoArgentino = valorReal / 0.05f;

            Console.WriteLine($"\n--- Conversões ---");
            Console.WriteLine($"Em dólar: USD {dolar:F2}");
            Console.WriteLine($"Em euro: EUR {euro:F2}");
            Console.WriteLine($"Em peso argentino: ARS {pesoArgentino:F2}");
        }
        static void Exercicio03()
        {

            int num1, num2;

            Console.Write("Digite o primeiro número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Valor inválido! Digite novamente o primeiro número: ");
            }

            Console.Write("Digite o segundo número inteiro: ");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Valor inválido! Digite novamente o segundo número: ");
            }

            if (num1 > num2)
            {
                Console.WriteLine($"Maior: {num1}");
                Console.WriteLine($"Menor: {num2}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"Maior: {num2}");
                Console.WriteLine($"Menor: {num1}");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }
        static void Exercicio04()
        {
            int idade;

            Console.Write("Digite a idade da pessoa: ");
            while (!int.TryParse(Console.ReadLine(), out idade))
            {
                Console.Write("Valor inválido! Digite a idade corretamente: ");
            }

            if (idade <= 13)
            {
                Console.WriteLine("Criança");
            }
            else if (idade <= 18)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade <= 60)
            {
                Console.WriteLine("Adulto");
            }
            else  // idade > 60
            {
                Console.WriteLine("Idoso");
            }
        }
        static void Exercicio05()
        {
            int valor;
            Console.Write("Digite um valor inteiro positivo: ");
            while (!int.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Console.Write("Valor inválido! Digite um número inteiro positivo: ");
            }

            int a = 0;
            int b = 1;

            Console.Write("Sequência Fibonacci até " + valor + ": ");

            // Imprime o primeiro número da sequência
            if (valor >= 0)
                Console.Write($"{a}");

            // Imprime os próximos números enquanto forem menores ou iguais ao valor
            int proximo = b;
            while (proximo <= valor)
            {
                Console.Write($", {proximo}");
                int temp = proximo;
                proximo = a + proximo;
                a = temp;
            }

            Console.WriteLine();
        }
        static void Exercicio06_BubbleSort()
        {
            int[] vetor = new int[1000];
            Random rand = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(0, 10000);
            }

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = 0; j < vetor.Length - 1 - i; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Primeiros 20 valores ordenados com Bubble Sort:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }
        static void Exercicio06_FuncaoSort()
        {
            int[] vetor = new int[1000];
            Random rand = new Random();

            // Preencher vetor com valores aleatórios de 0 a 9999
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rand.Next(0, 10000);
            }

            // Ordenar com função pronta
            Array.Sort(vetor);

            // Imprimir os primeiros 20 valores ordenados
            Console.WriteLine("Primeiros 20 valores ordenados com Array.Sort:");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();
        }
    }
    static void ExibirResumo()
{
    Console.Clear();
    Console.WriteLine("Resumo dos conceitos e sintaxes aprendidas neste arquivo C#\n");

    Console.WriteLine("1. Estrutura básica do programa em C#");
    Console.WriteLine("   - O ponto de entrada é o método estático Main().");
    Console.WriteLine("   - Os métodos auxiliares são criados como métodos estáticos na mesma classe.\n");

    Console.WriteLine("2. Entrada de dados segura com TryParse");
    Console.WriteLine("   - int.TryParse(string, out int) e float.TryParse(string, out float) convertem string para número.");
    Console.WriteLine("   - Retornam true se a conversão foi bem-sucedida e false se não.");
    Console.WriteLine("   - Usar em loops para garantir que o usuário digite um valor válido.");
    Console.WriteLine("   Exemplo:");
    Console.WriteLine("       while (!int.TryParse(Console.ReadLine(), out idade)) { ... }\n");

    Console.WriteLine("3. Interpolação de strings com $");
    Console.WriteLine("   - Facilita inserir variáveis e expressões dentro de strings.");
    Console.WriteLine("   - Colocar $ antes da string e usar {variavel} dentro dela.");
    Console.WriteLine("   Exemplo:");
    Console.WriteLine("       Console.WriteLine($\"A área é {area}\");\n");

    Console.WriteLine("4. Uso do Console");
    Console.WriteLine("   - Console.WriteLine() imprime texto e pula linha.");
    Console.WriteLine("   - Console.Write() imprime texto sem pular linha.");
    Console.WriteLine("   - Console.ReadLine() lê entrada do usuário como string.\n");

    Console.WriteLine("5. Controle de fluxo");
    Console.WriteLine("   - if, else if, else para decisões condicionais.");
    Console.WriteLine("   - while para laços (loops) que repetem enquanto a condição for verdadeira.\n");

    Console.WriteLine("6. Vetores (arrays)");
    Console.WriteLine("   - Declaração: int[] vetor = new int[1000];");
    Console.WriteLine("   - Acessar elementos: vetor[i]");
    Console.WriteLine("   - Percorrer com laços for.\n");

    Console.WriteLine("7. Ordenação manual (Bubble Sort)");
    Console.WriteLine("   - Algoritmo simples que compara elementos vizinhos e troca para ordenar.");
    Console.WriteLine("   - Exemplo no método Exercicio06_BubbleSort.\n");

    Console.WriteLine("8. Função pronta de ordenação");
    Console.WriteLine("   - Array.Sort(vetor) ordena o array rapidamente.\n");

    Console.WriteLine("9. Estrutura do menu interativo");
    Console.WriteLine("   - Uso do while para manter o programa ativo.");
    Console.WriteLine("   - switch para escolher o exercício a executar com base na entrada do usuário.");
    Console.WriteLine("   - Uso de Console.Clear() para limpar a tela e deixar visual organizado.\n");

    Console.WriteLine("10. Manipulação da sequência Fibonacci");
    Console.WriteLine("    - Uso de variáveis temporárias para calcular o próximo número.");
    Console.WriteLine("    - Impressão formatada em sequência na mesma linha.\n");

    Console.WriteLine("11. Tratamento de possíveis valores nulos");
    Console.WriteLine("    - Console.ReadLine() pode retornar null.");
    Console.WriteLine("    - Usar operador ?? para atribuir valor padrão e evitar erros, ex:");
    Console.WriteLine("      string opcao = Console.ReadLine() ?? \"\";\n");

    Console.WriteLine("12. Comentários no código");
    Console.WriteLine("    - // para comentários de linha única.");
    Console.WriteLine("    - /* ... */ para comentários de múltiplas linhas.");
    Console.WriteLine("    - Usar para explicar trechos importantes, facilitar o entendimento e futura revisão.\n");

    Console.WriteLine("---");
    Console.WriteLine("Dicas gerais:");
    Console.WriteLine("- Sempre validar entrada do usuário para evitar erros.");
    Console.WriteLine("- Organize seu código em métodos pequenos e claros.");
    Console.WriteLine("- Use nomes claros para variáveis e métodos.");
    Console.WriteLine("- Teste cada exercício separadamente antes de integrar tudo.");
    Console.WriteLine("- Use o menu para facilitar a execução dos exercícios.");
    Console.WriteLine("\nEste arquivo é um ótimo ponto de partida para praticar lógica, manipulação de dados, controle de fluxo e sintaxe básica do C#.");
    Console.WriteLine("\nBons estudos!");

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}
}
