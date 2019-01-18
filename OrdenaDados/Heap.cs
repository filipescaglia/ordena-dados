/*
 * Classe responsável pela técnica Heap Sort.
 */
namespace OrdenaDados {
    class Heap {

        private static int heapSize;

        private static void BuildHeap(int[] vet) {
            heapSize = vet.Length - 1;
            for (int i = heapSize / 2; i >= 0; i--) {
                Heapify(vet, i);
            }
        }

        private static void Swap(int[] vet, int x, int y) { // função para trocar os termos.
            int temp = vet[x];
            vet[x] = vet[y];
            vet[y] = temp;
        }
        private static void Heapify(int[] vet, int index) {
            int left = 2 * index;
            int right = 2 * index + 1;
            int largest = index;

            if (left <= heapSize && vet[left] > vet[index]) {
                largest = left;
            }

            if (right <= heapSize && vet[right] > vet[largest]) {
                largest = right;
            }

            if (largest != index) {
                Swap(vet, index, largest);
                Heapify(vet, largest);
            }
        }

        public static void Sort(int[] vet) {
            BuildHeap(vet);
            for (int i = vet.Length - 1; i >= 0; i--) {
                Swap(vet, 0, i);
                heapSize--;
                Heapify(vet, 0);
            }
        }
    }
}
