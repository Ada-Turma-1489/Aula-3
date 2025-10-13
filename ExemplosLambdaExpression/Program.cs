using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ExemplosLambdaExpression
{
    delegate int Operacao(int a, int b);

    public class Program
    {
        static void Main(string[] args)
        {
            var op = 1;
            Operacao operacao = Soma;

            switch (op)
            {
                case 1:
                    operacao = Soma;
                    break;

                case 2:
                    operacao = Sub;
                    break;

                default:
                    break;
            }

            Console.WriteLine(operacao(10, 4));

            // 1 - Delegates

            // 2 - Métodos Anônimos

            // 3 - Lambda Expression
        }

        public static int Soma(int a, int b)
        { 
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
