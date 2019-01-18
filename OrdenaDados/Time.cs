using System;
/*
 * Classe responsável pelos cálculos referentes ao tempo dos algoritmos.
 */
namespace OrdenaDados {
    class Time {

        public static void CalcTime(DateTime start, DateTime end) {
            TimeSpan t = end.Subtract(start);
            Console.WriteLine("O algoritmo levou " + t + " para ordenar o vetor.");
        }

    }
}
