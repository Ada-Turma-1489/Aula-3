using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace ExemplosLambdaExpression
{
    public class Program
    {
        public delegate int Operacao(int numero1, int numero2);

        static void Main(string[] args) 
        {


            var lista = new List<int>() { 10, 5, 2, 1};

            //var resultado = lista.Aggregate(0, Soma);
            //Console.WriteLine(resultado);

            var resultado = lista.Aggregate(0, (int agregado, int itemDaLista) => 
            {
                Console.WriteLine($"Chamou a Lambda com os parâmetros {agregado} e {itemDaLista}");
                var resultado = agregado + 2 * itemDaLista;
                Console.WriteLine($"Resultado é {resultado}");

                return resultado;
            });

            Console.WriteLine(resultado);
        }

        public static int Soma(int a, int b)
        {
            Console.WriteLine($"Chamou a função Soma com os parâmetros {a} e {b}");
            Console.WriteLine($"Resultado é {a+b}");
            return a + b;
        }

        public static int Subtracao(int a, int b)
        {
            return a - b;
        }
    }
}



// 1 - Delegates
// 2 - Métodos Anônimos
// 3 - Lambda Expression