/*
 * Classe responsável pela técnica Merge Sort.
 */
namespace OrdenaDados
{
    class Merge
    {

        public static void MainMerge(int[] numbers, int left, int mid, int right)
        {

            int[] temp = new int[numbers.Length];
            int i, eol, num, pos;

            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }

            while (left <= eol)
                temp[pos++] = numbers[left++];

            while (mid <= right)
                temp[pos++] = numbers[mid++];

            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        //Merge Sort recursivo.
        static public void Sort(int[] numbers, int left, int right)
        {

            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                Sort(numbers, left, mid);
                Sort(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}
