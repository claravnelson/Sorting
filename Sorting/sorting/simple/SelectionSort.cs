namespace Sorting.sorting.simple
{
    class SelectionSort
    {
        public static int[] Sorting(int[] vet)
        {
            long comparacoes = 0, atribuicoes = 0, trocas = 0;
            int n = vet.Length;
            atribuicoes++;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                atribuicoes++;

                for (int j = i + 1; j < n; j++)
                {
                    comparacoes++;
                    if (vet[j] < vet[min])
                    {
                        min = j;
                        atribuicoes++;
                    }
                }

                int tmp = vet[i];
                vet[i] = vet[min];
                vet[min] = tmp;
                atribuicoes += 3;
                trocas++;
            }

            Console.WriteLine("SelectionSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }
    }

}
