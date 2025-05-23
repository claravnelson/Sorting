using System;
using System.Diagnostics;
using System.IO;
using Sorting.basic_class.@static;
using Sorting.manager;
using Sorting.sorting.efficient;
using Sorting.sorting.simple;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu de Ordenação ---");
                Console.WriteLine("1. BubbleSort");
                Console.WriteLine("2. InsertionSort");
                Console.WriteLine("3. SelectionSort");
                Console.WriteLine("4. ShellSort");
                Console.WriteLine("5. QuickSort");
                Console.WriteLine("6. MergeSort");
                Console.WriteLine("7. HeapSort");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha o algoritmo: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0) break;

                Console.WriteLine("\nEscolha o arquivo:");
                Console.WriteLine("1. 100-aleatorios.txt");
                Console.WriteLine("2. 1000-aleatorios.txt");
                Console.WriteLine("3. 10000-aleatorios.txt");
                Console.WriteLine("4. 100000-aleatorios.txt");
                Console.WriteLine("5. 1000000-aleatorios.txt");
                Console.Write("Opção: ");
                int arquivoOpcao = int.Parse(Console.ReadLine());

                string caminhoArquivoRelativo = arquivoOpcao switch
                {

                    1 => "inputs/100-aleatorios.txt",
                    2 => "inputs/1000-aleatorios.txt",
                    3 => "inputs/10000-aleatorios.txt",
                    4 => "inputs/100000-aleatorios.txt",
                    5 => "inputs/1000000-aleatorios.txt",
                    _ => throw new Exception("Arquivo inválido")
                };

                string caminhoCompleto = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", caminhoArquivoRelativo);
                int[] vetorOriginal = Array.ConvertAll(File.ReadAllLines(caminhoCompleto), int.Parse);
                int[] vetor = (int[])vetorOriginal.Clone();

                Stopwatch sw = Stopwatch.StartNew();

                switch (opcao)
                {
                    case 1:
                        BubbleSort.Sorting(vetor);
                        break;
                    case 2:
                        InsertionSort.Sorting(vetor);
                        break;
                    case 3:
                        SelectionSort.Sorting(vetor);
                        break;
                    case 4:
                        ShellSort.Sorting(vetor);
                        break;
                    case 5:
                        QuickSort.Sorting(vetor);
                        break;
                    case 6:
                        MergeSort.Sorting(vetor);
                        break;
                    case 7:
                        HeapSort.Sorting(vetor);
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                sw.Stop();
                Console.WriteLine("Tempo de execução: " + sw.Elapsed.TotalSeconds + " segundos\n");

                Console.WriteLine("Vetor ordenado:");
                foreach (int numero in vetor)
                {
                    Console.Write(numero + " ");
                }
                Console.WriteLine("\n");

                //testes com o arquivo de 100 (questao 7)
                Console.WriteLine();
                /*
                Console.WriteLine("Questão 7");
                int[] dados = ManagerFileReader.Arquivo100TXT();
                Fila fila100 = new Fila(100);
                Pilha pilha100 = new Pilha(100);

                foreach (int numero in dados)
                {
                    fila100.Inserir(numero);
                    pilha100.Inserir(numero);
                }
                fila100.Remover();
                fila100.Remover();
                pilha100.Remover();
                pilha100.Remover();

                fila100.Mostrar();
                pilha100.Mostrar();
                */
                /*questão 9
                Console.WriteLine();
                Console.WriteLine("Questão 9");
                int[] testes = ManagerFileReader.Arquivo1000000TXT();

                Lista lista = new Lista(testes.Length);

                foreach (int numero in testes)
                {
                    lista.InserirFim(numero);
                }

                lista.RemoverInicio();
                lista.RemoverFim();
                lista.RemoverPosicao(500);

                int[] vetorParaOrdenar = new int[lista.cont];
                for (int i = 0; i < lista.cont; i++)
                {
                    vetorParaOrdenar[i] = lista.lista[i];
                }

                ShellSort.Sorting(vetorParaOrdenar);

                Console.WriteLine("Todos os elementos ordenados:");
                for (int i = 0; i < vetorParaOrdenar.Length; i++)
                {
                    Console.Write(vetorParaOrdenar[i] + " ");
                }

                Console.WriteLine();
            */
            }
        }
    }
}
