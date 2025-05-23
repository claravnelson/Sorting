namespace Sorting.basic_class.dynamic
{
    class ListaDynamic
    {
        public Celula? inicio;
        public Celula? fim;

        public static ListaDynamic FromArray(int[] vet)
        {
            ListaDynamic lista = new ListaDynamic();
            foreach (int num in vet)
            {
                lista.Adicionar(num);
            }
            return lista;
        }

        public void Adicionar(int valor)
        {
            Celula nova = new Celula(valor);
            if (inicio == null)
            {
                inicio = fim = nova;
            }
            else
            {
                fim!.prox = nova;
                fim = nova;
            }
        }

        public Celula? GetUltimaCelula()
        {
            return fim;
        }

        public int[] ToArray()
        {
            List<int> result = new List<int>();
            Celula? atual = inicio;
            while (atual != null)
            {
                result.Add(atual.valor);
                atual = atual.prox;
            }
            return result.ToArray();
        }
    }
}