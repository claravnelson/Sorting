namespace Sorting.sorting.specials
{
    class BucketSort
    {
        public static int[] Sorting(int[] vet)
        {
            int n = vet.Length;
            if (n <= 0) return vet;

            int max = vet[0];
            int min = vet[0];

            for (int i = 1; i < n; i++)
            {
                if (vet[i] > max) max = vet[i];
                if (vet[i] < min) min = vet[i];
            }

            int bucketCount = max - min + 1;
            List<int>[] buckets = new List<int>[bucketCount];

            for (int i = 0; i < bucketCount; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < n; i++)
            {
                buckets[vet[i] - min].Add(vet[i]);
            }

            int index = 0;
            for (int i = 0; i < bucketCount; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    vet[index] = buckets[i][j];
                    index++;
                }
            }

            return vet;
        }
    }
}
