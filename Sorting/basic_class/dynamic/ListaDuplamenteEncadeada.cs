using Sorting.basic_class.dynamic;

class ListaDuplamenteEncadeada
{
    public CelulaDupla? inicio;
    public CelulaDupla? fim;
    public int cont;

    public ListaDuplamenteEncadeada()
    {
        this.inicio = null;
        this.fim = null;
        this.cont = 0;
    }

    public bool InserirInicio(int item)
    {
        CelulaDupla nova = new CelulaDupla(item);

        if (inicio == null)
        {
            inicio = fim = nova;
        }
        else
        {
            nova.prox = inicio;
            inicio.ant = nova;
            inicio = nova;
        }

        cont++;
        return true;
    }

    public bool InserirFim(int item)
    {
        CelulaDupla nova = new CelulaDupla(item);

        if (fim == null)
        {
            inicio = fim = nova;
        }
        else
        {
            fim.prox = nova;
            nova.ant = fim;
            fim = nova;
        }

        cont++;
        return true;
    }

    public bool InserirPosicao(int pos, int item)
    {
        if (pos < 0 || pos > cont)
            return false;

        if (pos == 0)
            return InserirInicio(item);
        if (pos == cont)
            return InserirFim(item);

        CelulaDupla? atual = inicio;
        for (int i = 0; i < pos; i++)
        {
            atual = atual?.prox;
        }

        if (atual == null || atual.ant == null)
            return false;

        CelulaDupla nova = new CelulaDupla(item);
        nova.prox = atual;
        nova.ant = atual.ant;

        atual.ant.prox = nova;
        atual.ant = nova;

        cont++;
        return true;
    }

    public int RemoverInicio()
    {
        if (inicio == null)
        {
            Console.WriteLine("Lista vazia.");
            return -1;
        }

        int val = inicio.valor;

        if (inicio == fim)
        {
            inicio = fim = null;
        }
        else
        {
            inicio = inicio.prox;
            if (inicio != null)
                inicio.ant = null;
        }

        cont--;
        return val;
    }

    public int RemoverFim()
    {
        if (fim == null)
        {
            Console.WriteLine("Lista vazia.");
            return -1;
        }

        int val = fim.valor;

        if (inicio == fim)
        {
            inicio = fim = null;
        }
        else
        {
            fim = fim.ant;
            if (fim != null)
                fim.prox = null;
        }

        cont--;
        return val;
    }

    public int RemoverPosicao(int pos)
    {
        if (pos < 0 || pos >= cont)
        {
            Console.WriteLine("Posição inválida.");
            return -1;
        }

        if (pos == 0)
            return RemoverInicio();
        if (pos == cont - 1)
            return RemoverFim();

        CelulaDupla? atual = inicio;
        for (int i = 0; i < pos; i++)
        {
            atual = atual?.prox;
        }

        if (atual == null || atual.ant == null || atual.prox == null)
            return -1;

        atual.ant.prox = atual.prox;
        atual.prox.ant = atual.ant;

        cont--;
        return atual.valor;
    }

    public void Mostrar()
    {
        Console.Write("Lista Dupla: ");
        CelulaDupla? atual = inicio;
        while (atual != null)
        {
            Console.Write(atual.valor + " ");
            atual = atual.prox;
        }
        Console.WriteLine();
    }
}
