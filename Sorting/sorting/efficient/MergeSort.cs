namespace Sorting.sorting.efficient
{
    class MergeSort
    {
        static long comparacoes = 0, atribuicoes = 0, trocas = 0;

        public static int[] Sorting(int[] vet)
        {
            comparacoes = atribuicoes = trocas = 0;
            Sort(vet, 0, vet.Length - 1);
            Console.WriteLine("MergeSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }

        private static void Sort(int[] vet, int inicio, int fim)
        {
            comparacoes++;
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;
                atribuicoes++;
                Sort(vet, inicio, meio);
                Sort(vet, meio + 1, fim);
                Merge(vet, inicio, meio, fim);
            }
        }

        private static void Merge(int[] vet, int inicio, int meio, int fim)
        {
            int[] temp = new int[fim - inicio + 1];
            int i = inicio, j = meio + 1, k = 0;
            atribuicoes += 4;

            while (i <= meio && j <= fim)
            {
                comparacoes++;
                if (vet[i] <= vet[j])
                {
                    temp[k++] = vet[i++];
                }
                else
                {
                    temp[k++] = vet[j++];
                }
                atribuicoes += 2;
            }

            while (i <= meio)
            {
                comparacoes++;
                temp[k++] = vet[i++];
                atribuicoes += 2;
            }

            while (j <= fim)
            {
                comparacoes++;
                temp[k++] = vet[j++];
                atribuicoes += 2;
            }

            for (i = inicio, k = 0; i <= fim; i++, k++)
            {
                vet[i] = temp[k];
                atribuicoes++;
            }
        }
    }
}
