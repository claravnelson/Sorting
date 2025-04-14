namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(vet, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = vet[0];
                vet[0] = vet[i];
                vet[i] = temp;

                Heapify(vet, i, 0);
            }

            return vet;
        }

        private static void Heapify(int[] vet, int n, int i)
        {
            int maior = i;
            int esq = 2 * i + 1;
            int dir = 2 * i + 2;

            if (esq < n && vet[esq] > vet[maior])
            {
                maior = esq;
            }

            if (dir < n && vet[dir] > vet[maior])
            {
                maior = dir;
            }

            if (maior != i)
            {
                int temp = vet[i];
                vet[i] = vet[maior];
                vet[maior] = temp;

                Heapify(vet, n, maior);
            }
        }
    }
}
