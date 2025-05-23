using Sorting.basic_class.dynamic;

namespace Sorting.print
{
    static class PrintSolutionDynamic
    {
        public static void ImprimirLista(string estrutura, Celula? inicio)
        {
            Console.WriteLine("ESTRUTURA - " + estrutura + "\n");

            Console.WriteLine("INICIO - Imprimindo estrutura em alocação dinâmica sem pular linha.\n");

            Celula? atual = inicio;
            while (atual != null)
            {
                Console.Write(atual.valor + " ");
                atual = atual.prox;
            }

            Console.Write("\n");
            Console.WriteLine("\nFIM - Imprimindo estrutura em alocação dinâmica sem pular linha.\n");
        }

        public static void ImprimirListaComQuebra(string estrutura, Celula? inicio)
        {
            Console.WriteLine("INICIO - Imprimindo estrutura dinâmica com quebra de linha.\n");

            Celula? atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.prox;
            }

            Console.WriteLine("\nFIM - Imprimindo estrutura dinâmica com quebra de linha.");
        }
    }
}
