/*
 * Classe responsável pela técnica Bubble Sort.
 */
namespace OrdenaDados
{
    class Bubble
    {

        public static void Sort(int[] vet)
        {
            int repos = 0;

            for (int i = 0; i < vet.Length - 1; i++)
            {
                for (int j = 0; j < vet.Length - (i + 1); j++)
                {
                    if (vet[j] > vet[j + 1])
                    {
                        repos = vet[j];
                        vet[j] = vet[j + 1];
                        vet[j + 1] = repos;
                    }
                }
            }
        }
    }
}
