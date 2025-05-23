namespace Sorting.basic_class.dynamic
{
    class PilhaDynamic
    {
        public Celula? topo;

        public PilhaDynamic()
        {
            this.topo = null;
        }

        public bool Inserir(int item)
        {
            Celula nova = new Celula(item);
            nova.prox = this.topo;
            this.topo = nova;
            return true;
        }

        public int Remover()
        {
            if (this.topo == null)
            {
                Console.WriteLine("Pilha vazia. Não é possível remover.");
                return -1;
            }

            int valor = this.topo.valor;
            this.topo = this.topo.prox;
            return valor;
        }

        public void Mostrar()
        {
            Console.Write("Pilha: ");
            Celula? atual = this.topo;
            while (atual != null)
            {
                Console.Write(atual.valor + " ");
                atual = atual.prox;
            }
            Console.WriteLine();
        }
    }
}