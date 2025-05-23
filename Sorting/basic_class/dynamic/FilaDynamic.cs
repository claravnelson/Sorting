namespace Sorting.basic_class.dynamic
{
    class FilaDynamic
    {
        public Celula? inicio;
        public Celula? fim;

        public FilaDynamic()
        {
            this.inicio = null;
            this.fim = null;
        }

        public bool Inserir(int item)
        {
            Celula nova = new Celula(item);
            if (this.fim == null)
            {
                this.inicio = nova;
                this.fim = nova;
            }
            else
            {
                this.fim.prox = nova;
                this.fim = nova;
            }
            return true;
        }

        public int Remover()
        {
            if (this.inicio == null)
            {
                Console.WriteLine("Fila vazia. Não é possível remover.");
                return -1;
            }

            int valor = this.inicio.valor;
            this.inicio = this.inicio.prox;

            if (this.inicio == null)
            {
                this.fim = null;
            }

            return valor;
        }

        public void Mostrar()
        {
            Console.Write("Fila: ");
            Celula? atual = this.inicio;
            while (atual != null)
            {
                Console.Write(atual.valor + " ");
                atual = atual.prox;
            }
        }
    }
}

