namespace Sorting.sorting.specials
{
    class BucketSort
    {
        public static long comparacoes = 0;
        public static long atribuicoes = 0;
        public static long trocas = 0;

        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;
            atribuicoes++; // atribuicao de n

            if (n <= 0) return vet;

            int max = vet[0];
            int min = vet[0];
            atribuicoes += 2;

            for (int i = 1; i < n; i++)
            {
                comparacoes++;
                if (vet[i] > max)
                {
                    max = vet[i];
                    atribuicoes++;
                }
                comparacoes++;
                if (vet[i] < min)
                {
                    min = vet[i];
                    atribuicoes++;
                }
            }

            int bucketCount = max - min + 1;
            atribuicoes++;
            List<int>[] buckets = new List<int>[bucketCount];
            atribuicoes++;

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
                atribuicoes++;
            }

            for (int i = 0; i < n; i++)
            {
                buckets[vet[i] - min].Add(vet[i]);
                atribuicoes++;
            }

            int index = 0;
            atribuicoes++;
            for (int i = 0; i < bucketCount; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    vet[index] = buckets[i][j];
                    atribuicoes++;
                    trocas++;
                    index++;
                    atribuicoes++;
                }
            }

            Console.WriteLine("BucketSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }
    }
}
