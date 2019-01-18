using System;
/*
 * Classe responsável pelo gerenciamento dos vetores.
 */
namespace OrdenaDados {
    class Vector {
        public static int[] v, vO; //v -> Vetor que será ordenado   vO -> Vetor preservado sem ordenação para comparação.
        static Random r = new Random(DateTime.Now.Millisecond); //Variável que servirá de 'seed' para a geração dos valores
                                                                // que serão usados internamente nos vetores.
        
        //Método responsável pela criação dos vetores.
        public static void NewVector(int length) {
            v = new int[length];
            vO = new int[length];

            for (int i = 0; i < length; i++) {
                v[i] = r.Next(0, 100000);
                vO[i] = v[i];
            }
        }

        //Método responsável pela cópia do vetor não-ordenado para o vetor que será ordenado.
        public static void CopyVector() {
            for (int i = 0; i < v.Length; i++) {
                v[i] = vO[i];
            }
        }

        //Método responsável pela exibição do vetor não-ordenado.
        public static void ShowOriginalVector() {
            foreach (int x in vO) {
                Console.Write(x + "      ");
            }
            Console.WriteLine();
        }

        //Método responsável pela exibição do vetor ordenado.
        public static void ShowSortedVector() {
            foreach (int x in v) {
                Console.Write(x + "      ");
            }
            Console.WriteLine();
        }
    }
}
