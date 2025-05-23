namespace Sorting.sorting.specials
{
    class CountingSort
    {
        public static long comparacoes = 0;
        public static long atribuicoes = 0;
        public static long trocas = 0;

        public static int[] Sorting(int[] vet)
        {
            if (vet.Length == 0) return vet;

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

            int[] count = new int[max + 1];
            atribuicoes++;

            for (int i = 0; i < vet.Length; i++)
            {
                count[vet[i]]++;
                atribuicoes++;
            }

            int index = 0;
            atribuicoes++;
            for (int i = 0; i < count.Length; i++)
            {
                while (count[i] > 0)
                {
                    comparacoes++;
                    vet[index] = i;
                    atribuicoes++;
                    trocas++;
                    index++;
                    atribuicoes++;
                    count[i]--;
                    atribuicoes++;
                }
                comparacoes++;
            }

            Console.WriteLine("CountingSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }
    }
}
