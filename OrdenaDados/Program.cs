using System;
/*
 * Classe principal do programa.
 */
namespace OrdenaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, qtVet;
            DateTime start, end;

            do
            {
                Console.WriteLine("::::::: MENU :::::::");
                Console.WriteLine("1 - Gerar vetor com números aleatórios");
                Console.WriteLine("2 - Gerar vetor a partir de um arquivo");
                Console.WriteLine("3 - Bubble sort");
                Console.WriteLine("4 - Insertion sort");
                Console.WriteLine("5 - Selection sort");
                Console.WriteLine("6 - Quick sort");
                Console.WriteLine("7 - Merge sort");
                Console.WriteLine("8 - Shaker sort");
                Console.WriteLine("9 - Heap sort");
                Console.WriteLine("10 - Exibir vetor original");
                Console.WriteLine("11 - Exibir vetor ordenado");
                Console.WriteLine("0 - Encerrar programa");
                Console.WriteLine();
                Console.Write("Digite a opção desejada: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("Digite a quantidade de números no vetor: ");
                        qtVet = int.Parse(Console.ReadLine());
                        Vector.NewVector(qtVet);
                        Console.WriteLine("\nVetor gerado com sucesso!\n");
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("::::::: INSTRUÇÕES PARA LEITURA DO ARQUIVO :::::::");
                        Console.WriteLine("Por favor, certifique-se de que a pasta 'Files' contém o seu arquivo 'source.txt'" +
                            " para que os dados sejam obtidos corretamente.");
                        Console.WriteLine("Verifique também se os dados estão separados por uma ','.");
                        Console.WriteLine("Exemplo:");
                        Console.WriteLine("100,101,102,103...");
                        Console.WriteLine("Após a verificação pressione ENTER.");
                        Console.ReadLine();

                        string sourceFilePath = @"..\..\..\Files\source.txt";
                        Vector.FileVector(sourceFilePath);

                        break;

                    case 3:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Bubble.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 4:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Insertion.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 5:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Selection.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 6:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Quick.Sort(Vector.v, 0, Vector.v.Length - 1);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 7:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Merge.MergeSort(Vector.v, 0, Vector.v.Length - 1);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 8:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Shaker.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 9:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Heap.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 10:
                        Vector.ShowOriginalVector();
                        Console.WriteLine();
                        break;

                    case 11:
                        Vector.ShowSortedVector();
                        Console.WriteLine();
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Por favor, digite uma opção válida.");
                        Console.WriteLine();
                        break;
                }

            } while (menu != 0);
        }
    }
}
