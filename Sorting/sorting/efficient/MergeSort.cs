namespace Sorting.sorting.efficient
{
    class MergeSort
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
                int meio = (inicio + fim) / 2;
                Sort(vet, inicio, meio);
                Sort(vet, meio + 1, fim);
                Merge(vet, inicio, meio, fim);
            }
        }

        private static void Merge(int[] vet, int inicio, int meio, int fim)
        {
            int[] temp = new int[fim - inicio + 1];
            int i = inicio;
            int j = meio + 1;
            int k = 0;

            while (i <= meio && j <= fim)
            {
                if (vet[i] <= vet[j])
                {
                    temp[k] = vet[i];
                    i++;
                }
                else
                {
                    temp[k] = vet[j];
                    j++;
                }
                k++;
            }

            while (i <= meio)
            {
                temp[k] = vet[i];
                i++;
                k++;
            }

            while (j <= fim)
            {
                temp[k] = vet[j];
                j++;
                k++;
            }

            for (i = inicio, k = 0; i <= fim; i++, k++)
            {
                vet[i] = temp[k];
            }
        }
    }
}
