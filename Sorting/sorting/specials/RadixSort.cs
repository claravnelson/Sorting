namespace Sorting.sorting.specials
{
    class RadixSort
    {
        public static long comparacoes = 0;
        public static long atribuicoes = 0;
        public static long trocas = 0;

        public static int[] Sorting(int[] vet)
        {
            int max = GetMax(vet);
            atribuicoes++;

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                comparacoes++;
                CountSort(vet, exp);
            }

            Console.WriteLine("RadixSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }

        private static int GetMax(int[] vet)
        {
            int max = vet[0];
            atribuicoes++;
            for (int i = 1; i < vet.Length; i++)
            {
                comparacoes++;
                if (vet[i] > max)
                {
                    max = vet[i];
                    atribuicoes++;
                }
            }
            return max;
        }

        private static void CountSort(int[] vet, int exp)
        {
            int n = vet.Length;
            int[] output = new int[n];
            int[] count = new int[10];
            atribuicoes += 3;

            for (int i = 0; i < n; i++)
            {
                int pos = (vet[i] / exp) % 10;
                count[pos]++;
                atribuicoes += 2;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
                atribuicoes++;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int pos = (vet[i] / exp) % 10;
                output[count[pos] - 1] = vet[i];
                count[pos]--;
                atribuicoes += 3;
                trocas++;
            }

            for (int i = 0; i < n; i++)
            {
                vet[i] = output[i];
                atribuicoes++;
                trocas++;
            }
        }
    }
}
