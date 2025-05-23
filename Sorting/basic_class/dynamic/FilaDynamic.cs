namespace Sorting.basic_class.dynamic
{
    class FilaDynamic
    {
        public Celula? primeiro;
        public Celula? ultimo;

        public FilaDynamic()
        {
            // Inicializa com uma célula "dummy" (valor padrão, como 0 ou -1)
            this.primeiro = this.ultimo = new Celula(-1); // Use um valor adequado
        }

        public bool Inserir(int item)
        {
            this.ultimo.valor = item;
            this.ultimo.prox = new Celula(-1); // Valor inicial para a nova célula
            this.ultimo = this.ultimo.prox;

            return true;
        }

        public int Remover()
        {
            if (this.ultimo == this.primeiro)
            {
                Console.WriteLine("Não é possível remover da fila.");
                return -1; // Retorno padrão para erro
            }

            Celula? tmp = primeiro;
            int valorRemovido = tmp.valor; // Armazena o valor antes de remover
            this.primeiro = primeiro.prox;

            return valorRemovido; // Retorna o valor removido
        }
    }
}