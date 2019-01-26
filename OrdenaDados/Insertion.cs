/*
 * Classe responsável pela técnica Insertion Sort.
 */
namespace OrdenaDados
{
    class Insertion
    {

        public static void Sort(int[] vet)
        {
            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (vet[j - 1] > vet[j])
                    {
                        int tmp = vet[j - 1];
                        vet[j - 1] = vet[j];
                        vet[j] = tmp;
                    }
                }
            }
        }
    }
}
