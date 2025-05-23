namespace Sorting.sorting.efficient
{
    class HeapSort
    {
        static long comparacoes = 0, atribuicoes = 0, trocas = 0;

        public static int[] Sorting(int[] vet)
        {
            comparacoes = atribuicoes = trocas = 0;
            int n = vet.Length;
            atribuicoes++;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                atribuicoes++;
                Heapify(vet, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                atribuicoes++;
                int temp = vet[0];
                vet[0] = vet[i];
                vet[i] = temp;
                atribuicoes += 3;
                trocas++;

                Heapify(vet, i, 0);
            }

            Console.WriteLine("HeapSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }

        private static void Heapify(int[] vet, int n, int i)
        {
            int maior = i;
            int esq = 2 * i + 1;
            int dir = 2 * i + 2;
            atribuicoes += 3;

            comparacoes++;
            if (esq < n && vet[esq] > vet[maior])
            {
                maior = esq;
                atribuicoes++;
            }

            comparacoes++;
            if (dir < n && vet[dir] > vet[maior])
            {
                maior = dir;
                atribuicoes++;
            }

            comparacoes++;
            if (maior != i)
            {
                int temp = vet[i];
                vet[i] = vet[maior];
                vet[maior] = temp;
                atribuicoes += 3;
                trocas++;

                Heapify(vet, n, maior);
            }
        }
    }
}
