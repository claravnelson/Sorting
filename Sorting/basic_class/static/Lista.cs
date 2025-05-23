namespace Sorting.basic_class.@static
{
    class Lista
    {
        public int[] lista;
        public int cont;

        public Lista(int n)
        {
            lista = new int[n];
            cont = 0;
        }

        public bool InserirFim(int item)
        {
            if (cont < lista.Length)
            {
                lista[cont] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirInicio(int item)
        {
            if (cont < lista.Length)
            {
                for (int i = cont; i > 0; i--)
                {
                    lista[i] = lista[i - 1];
                }
                lista[0] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Lista está cheia, não é possível inserir " + item);
                return false;
            }
        }

        public bool InserirPosicao(int pos, int item)
        {
            if (cont < lista.Length && pos >= 0 && pos <= cont)
            {
                for (int i = cont; i > pos; i--)
                {
                    lista[i] = lista[i - 1];
                }
                lista[pos] = item;
                cont++;
                return true;
            }
            else
            {
                Console.WriteLine("Posição inválida ou lista cheia.");
                return false;
            }
        }

        public int RemoverFim()
        {
            if (cont > 0)
            {
                cont--;
                return lista[cont];
            }
            else
            {
                Console.WriteLine("Lista vazia, nada a remover.");
                return -1;
            }
        }

        public int RemoverInicio()
        {
            if (cont > 0)
            {
                int removido = lista[0];
                for (int i = 0; i < cont - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                cont--;
                return removido;
            }
            else
            {
                Console.WriteLine("Lista vazia, nada a remover.");
                return -1;
            }
        }

        public int RemoverPosicao(int pos)
        {
            if (pos >= 0 && pos < cont)
            {
                int removido = lista[pos];
                for (int i = pos; i < cont - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                cont--;
                return removido;
            }
            else
            {
                Console.WriteLine("Posição inválida.");
                return -1;
            }
        }
        
    }
}

