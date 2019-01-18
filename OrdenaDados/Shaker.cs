/*
 * Classe responsável pela técnica Shaker Sort.
 */
namespace OrdenaDados {
    class Shaker {

        public static void Sort(int[] vet) {
            bool swapped = true;
            int start = 0;
            int end = vet.Length;

            while (swapped == true) {
                // Reseta a flag swapped ao entrar no loop, pois poderia ser verdadeiro
                // devido uma iteração anterior.
                swapped = false;

                // loop igual ao bubble sort.
                for (int i = start; i < end - 1; i++) {
                    if (vet[i] > vet[i + 1]) {
                        int tmp = vet[i];
                        vet[i] = vet[i + 1];
                        vet[i + 1] = tmp;
                        swapped = true;
                    }
                }

                // Se nada se moveu, então o vetor está ordenado.
                if (swapped == false) break;

                // Caso contrário, reseta a flag para ser usada no próximo estágio.
                swapped = false;

                end = end - 1;

                // loop contrário, realizando as mesmas comparações do anterior.
                for (int i = end - 1; i >= start; i--) {
                    if (vet[i] > vet[i + 1]) {
                        int tmp = vet[i];
                        vet[i] = vet[i + 1];
                        vet[i + 1] = tmp;
                        swapped = true;
                    }
                }

                start = start + 1;
            }
        }
    }
}
