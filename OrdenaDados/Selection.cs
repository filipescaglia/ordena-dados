/*
 * Classe responsável pela técnica Selection Sort.
 */
namespace OrdenaDados
{
    class Selection
    {

        public static void Sort(int[] vet)
        {
            int smallest;
            for (int i = 0; i < vet.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < vet.Length; index++)
                {
                    if (vet[index] < vet[smallest])
                    {
                        smallest = index;
                    }
                }
                Swap(vet, i, smallest);
            }
        }

        public static void Swap(int[] vet, int first, int second)
        {
            int temporary = vet[first];
            vet[first] = vet[second];
            vet[second] = temporary;
        }
    }
}
