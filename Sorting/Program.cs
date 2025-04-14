using Sorting.basic_class.@static;
using Sorting.manager;
using Sorting.print;

public class Program
{
    public static void Main(string[] args)
    {
        // https://github.com/accj1990/Sorting.git
        // https://pt.overleaf.com/read/kptbxrwtrzch#8b9776
        // Agora funciona
        int[] vet = ManagerFileReader.Arquivo10TXT();

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);

        ManagerFileSorting.Ordenar(Sorting.enums.Sortings.SHELLSORT, vet);

        PrintSolutionStatic.ImprimirArrayMesmaLinha(vet, Sorting.enums.Sortings.SHELLSORT);


        // Crie um menu que solicite ao usuário qual é o arquivo que será lido e qual algoritmo deverá ser executado


        // Fila, Pilha e Lista em alocação estática
        Fila f = new Fila(5);

        f.Inserir(1);
        f.Inserir(2);
        f.Inserir(3);
        f.Inserir(4);
        f.Inserir(5);

        f.Mostrar();

        f.Inserir(6); // não consigo inserir pois a fila está cheia

        f.Remover();

        f.Mostrar();

        f.Inserir(6);

        f.Mostrar();

        f.Remover();

        f.Remover();

        f.Remover();

        f.Mostrar();

        // Pilha
        Pilha p = new Pilha(5);

        p.Inserir(1);
        p.Inserir(2);
        p.Inserir(3);
        p.Inserir(4);
        p.Inserir(5);

        p.Mostrar();
        p.Inserir(6);

        p.Remover();
        p.Remover();

        p.Mostrar();

    }
}