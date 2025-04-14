namespace Sorting.sorting.specials
{
    class RadixSort
    {
        public static int[] Sorting(int[] vet)
        {
            int max = GetMax(vet);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(vet, exp);
            }

            return vet;
        }

        private static int GetMax(int[] vet)
        {
            int max = vet[0];
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > max) max = vet[i];
            }
            return max;
        }

        private static void CountSort(int[] vet, int exp)
        {
            int n = vet.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(vet[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int pos = (vet[i] / exp) % 10;
                output[count[pos] - 1] = vet[i];
                count[pos]--;
            }

            for (int i = 0; i < n; i++)
            {
                vet[i] = output[i];
            }
        }
    }
}
