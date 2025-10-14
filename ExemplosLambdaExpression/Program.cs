using System.Threading.Channels;

namespace ExemplosLambdaExpression
{
    public class Program
    {
        public delegate int Operacao(int numero1, int numero2);

        static void Main(string[] args) // Entry Point
        {
            Operacao variavel1 = Soma; // Qualquer coisa que retorne int e receba dois ints;
            Operacao variavel2 = Subtracao; // Qualquer coisa que retorne int e receba dois ints;

            // Executar a Soma
            ExecutaOperacao(variavel1);

            // Executar a Subtração
            ExecutaOperacao(variavel2);

            // Métodos Anônimos
            ExecutaOperacao(delegate (int a, int b) // <- Método Sem Nome (inline)
            {
                return a + b;
            }); // Open Closed Principle 

            // Lambda `entrada => saida`
            ExecutaOperacao((int a, int b) => a + b);
            ExecutaOperacao((int a, int b) => a - b);
            ExecutaOperacao((int a, int b) => a / b);
            ExecutaOperacao((int a, int b) => a * b);
            ExecutaOperacao((int a, int b) => Math.Max(a, b));
            ExecutaOperacao((int a, int b) => (int)Math.Pow(a, b));
            ExecutaOperacao((int a, int b) => 
            {
                Console.WriteLine($"Executando o pow entre {a} e {b}");

                var resultado = (int)Math.Pow(a, b);

                Console.WriteLine($"O resultado é {resultado}");

                return resultado;
            });
        }
 
        public static void ExecutaOperacao(Operacao operacao)
        {
            var resultado = operacao(7, 3);
            Console.WriteLine($"O resultado da Operação é: {resultado}");
        }

        // Assinatura do Método -> Tipo de Retorno, Parâmetros (ordem e os tipos)
        // Retorna Int, Recebe dois Ints
        public static int Soma(int a, int b)
        {
            return a + b;
        }

        // Retorna Int, Recebe dois Ints
        public static int Subtracao(int a, int b)
        {
            return a - b;
        }
    }
}



// 1 - Delegates
// 2 - Métodos Anônimos
// 3 - Lambda Expression