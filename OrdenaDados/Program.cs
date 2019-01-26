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
                Console.WriteLine("1 - Gerar vetor");
                Console.WriteLine("2 - Bubble sort");
                Console.WriteLine("3 - Insertion sort");
                Console.WriteLine("4 - Selection sort");
                Console.WriteLine("5 - Quick sort");
                Console.WriteLine("6 - Merge sort");
                Console.WriteLine("7 - Shaker sort");
                Console.WriteLine("8 - Heap sort");
                Console.WriteLine("9 - Exibir vetor original");
                Console.WriteLine("10 - Exibir vetor ordenado");
                Console.WriteLine("0 - Encerrar programa");
                Console.WriteLine();
                Console.Write("Escolha a opção desejada: ");
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
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Bubble.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 3:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Insertion.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 4:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Selection.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 5:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Quick.Sort(Vector.v, 0, Vector.v.Length - 1);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 6:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Merge.Sort(Vector.v, 0, Vector.v.Length - 1);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 7:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Shaker.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 8:
                        Vector.CopyVector();
                        start = DateTime.Now;
                        Heap.Sort(Vector.v);
                        end = DateTime.Now;
                        Console.WriteLine("Vetor ordenado com sucesso!");
                        Time.CalcTime(start, end);
                        break;

                    case 9:
                        Vector.ShowOriginalVector();
                        Console.WriteLine();
                        break;

                    case 10:
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
