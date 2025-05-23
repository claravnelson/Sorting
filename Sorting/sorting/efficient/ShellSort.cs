namespace Sorting.sorting.efficient
{
    class ShellSort
    {
        public static int[] Sorting(int[] vet)
        {
            long comparacoes = 0, atribuicoes = 0, trocas = 0;
            int n = vet.Length;
            int gap = n / 2;
            atribuicoes += 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = vet[i];
                    int j = i;
                    atribuicoes += 2;

                    while (j >= gap && vet[j - gap] > temp)
                    {
                        comparacoes++;
                        vet[j] = vet[j - gap];
                        j -= gap;
                        atribuicoes += 2;
                        trocas++;
                    }

                    comparacoes++;
                    vet[j] = temp;
                    atribuicoes++;
                }
                gap /= 2;
                atribuicoes++;
            }

            Console.WriteLine("ShellSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }
    }
}

