namespace Sorting.sorting.efficient
{
    class QuickSort
    {
        public static int[] Sorting(int[] vet)
        {
            long comparacoes = 0, atribuicoes = 0, trocas = 0;

            void Trocar(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
                atribuicoes += 3;
                trocas++;
            }

            int Particionar(int[] arr, int baixo, int alto)
            {
                int pivo = arr[alto];
                atribuicoes++;
                int i = baixo - 1;
                atribuicoes++;

                for (int j = baixo; j < alto; j++)
                {
                    comparacoes++;
                    if (arr[j] <= pivo)
                    {
                        i++;
                        atribuicoes++;
                        Trocar(ref arr[i], ref arr[j]);
                    }
                }
                Trocar(ref arr[i + 1], ref arr[alto]);
                return i + 1;
            }

            void QuickSortRecursivo(int[] arr, int baixo, int alto)
            {
                comparacoes++;
                if (baixo < alto)
                {
                    int pi = Particionar(arr, baixo, alto);
                    atribuicoes++;
                    QuickSortRecursivo(arr, baixo, pi - 1);
                    QuickSortRecursivo(arr, pi + 1, alto);
                }
            }

            QuickSortRecursivo(vet, 0, vet.Length - 1);
            Console.WriteLine("QuickSort - Comparacoes: " + comparacoes + ", Atribuicoes: " + atribuicoes + ", Trocas: " + trocas);
            return vet;
        }
    }
}
