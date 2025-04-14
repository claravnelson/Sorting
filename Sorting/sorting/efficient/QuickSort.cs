namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        public static int[] Sorting(int[] vet)
        {
            Sort(vet, 0, vet.Length - 1);
            return vet;
        }

        private static void Sort(int[] vet, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int p = Particionar(vet, inicio, fim);
                Sort(vet, inicio, p - 1);
                Sort(vet, p + 1, fim);
            }
        }

        private static int Particionar(int[] vet, int inicio, int fim)
        {
            int pivo = vet[fim];
            int i = inicio - 1;

            for (int j = inicio; j < fim; j++)
            {
                if (vet[j] < pivo)
                {
                    i++;
                    int tmp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = tmp;
                }
            }

            int aux = vet[i + 1];
            vet[i + 1] = vet[fim];
            vet[fim] = aux;

            return i + 1;
        }
    }
}
