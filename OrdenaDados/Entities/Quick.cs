/*
 * Classe responsável pela técnica Quicksort.
 */
namespace OrdenaDados
{
    class Quick
    {

        public static void Sort(int[] vet, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(vet, left, right);

                if (pivot > 1)
                {
                    Sort(vet, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Sort(vet, pivot + 1, right);
                }
            }
        }

        private static int Partition(int[] vet, int left, int right)
        {
            int pivot = vet[left];
            while (true)
            {

                while (vet[left] < pivot)
                {
                    left++;
                }

                while (vet[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (vet[left] == vet[right]) return right;

                    int temp = vet[left];
                    vet[left] = vet[right];
                    vet[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
