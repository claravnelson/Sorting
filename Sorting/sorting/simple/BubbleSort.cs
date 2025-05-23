namespace Sorting.sorting.simple
{
    class BubbleSort
    {
        public static int[] Sorting(int[] vet)
        {
            long comparacoes = 0, atribuicoes = 0, trocas = 0;
            int n = vet.Length;
            atribuicoes++;

            for (int i = 0; i < n; i++)
            {
                atribuicoes++;
                for (int j = n - 1; j > i; j--)
                {
                    atribuicoes++;
                    comparacoes++;
                    if (vet[j] < vet[j - 1])
                    {
                        int tmp = vet[j];
                        vet[j] = vet[j - 1];
                        vet[j - 1] = tmp;
                        atribuicoes += 3;
                        trocas++;
                    }
                }
            }

            Console.WriteLine("BubbleSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }
    }

}
