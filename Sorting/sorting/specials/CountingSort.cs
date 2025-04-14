namespace Sorting.sorting.specials
{
    class CountingSort
    {
        public static int[] Sorting(int[] vet)
        {
            if (vet.Length == 0) return vet;

            int max = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > max) max = vet[i];
            }

            int[] count = new int[max + 1];
            for (int i = 0; i < vet.Length; i++)
            {
                count[vet[i]]++;
            }

            int index = 0;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    vet[index] = i;
                    index++;
                    count[i]--;
                }
            }

            return vet;
        }
    }
}
