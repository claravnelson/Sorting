namespace Sorting.sorting.simple
{
    class InsertionSort
    {
        public static int[] Sorting(int[] vet)
        {
            long comparacoes = 0, atribuicoes = 0, trocas = 0;
            int n = vet.Length;
            atribuicoes++;

            for (int i = 1; i < n; i++)
            {
                int caixa = vet[i];
                int j = i - 1;
                atribuicoes += 2;

                while (j >= 0 && vet[j] > caixa)
                {
                    comparacoes++;
                    vet[j + 1] = vet[j];
                    j--;
                    atribuicoes += 2;
                    trocas++;
                }
                comparacoes++;
                vet[j + 1] = caixa;
                atribuicoes++;
            }

            Console.WriteLine("InsertionSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }
    }

}
