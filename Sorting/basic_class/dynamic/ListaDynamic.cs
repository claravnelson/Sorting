namespace Sorting.basic_class.dynamic
{
    class ListaDynamic
    {
        private Celula? inicio;

        public ListaDynamic()
        {
            this.inicio = null;
        }

        public void InserirInicio(int item)
        {
            Celula nova = new Celula(item);
            nova.prox = inicio;
            inicio = nova;
        }

        public void InserirFinal(int item)
        {
            Celula nova = new Celula(item);
            if (inicio == null)
            {
                inicio = nova;
                return;
            }

            Celula atual = inicio;
            while (atual.prox != null)
            {
                atual = atual.prox;
            }
            atual.prox = nova;
        }

        public bool InserirPosicao(int item, int pos)
        {
            if (pos < 0) return false;

            if (pos == 0)
            {
                InserirInicio(item);
                return true;
            }

            Celula atual = inicio;
            int i = 0;
            while (atual != null && i < pos - 1)
            {
                atual = atual.prox;
                i++;
            }

            if (atual == null) return false;

            Celula nova = new Celula(item);
            nova.prox = atual.prox;
            atual.prox = nova;
            return true;
        }

        public bool RemoverInicio()
        {
            if (inicio == null) return false;

            inicio = inicio.prox;
            return true;
        }

        public bool RemoverFinal()
        {
            if (inicio == null) return false;

            if (inicio.prox == null)
            {
                inicio = null;
                return true;
            }

            Celula atual = inicio;
            while (atual.prox.prox != null)
            {
                atual = atual.prox;
            }
            atual.prox = null;
            return true;
        }

        public bool RemoverPosicao(int pos)
        {
            if (pos < 0 || inicio == null) return false;

            if (pos == 0)
            {
                return RemoverInicio();
            }

            Celula atual = inicio;
            int i = 0;
            while (atual.prox != null && i < pos - 1)
            {
                atual = atual.prox;
                i++;
            }

            if (atual.prox == null) return false;

            atual.prox = atual.prox.prox;
            return true;
        }

        public void Mostrar()
        {
            Console.Write("Lista: ");
            Celula? atual = inicio;
            while (atual != null)
            {
                Console.Write(atual.valor + " ");
                atual = atual.prox;
            }
            Console.WriteLine();
        }
    }
}