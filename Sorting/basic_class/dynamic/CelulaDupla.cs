using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CelulaDupla
{
    public int valor;
    public CelulaDupla? prox;
    public CelulaDupla? ant;

    public CelulaDupla()
    {
        this.valor = -1;
        this.prox = null;
        this.ant = null;
    }

    public CelulaDupla(int valor)
    {
        this.valor = valor;
        this.prox = null;
        this.ant = null;
    }
}
