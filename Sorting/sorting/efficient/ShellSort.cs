namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = vet[i];
                    int j = i;

                    while (j >= gap && vet[j - gap] > temp)
                    {
                        vet[j] = vet[j - gap];
                        j -= gap;
                    }

                    vet[j] = temp;
                }

                gap /= 2;
            }

            return vet;
        }

    }
}

