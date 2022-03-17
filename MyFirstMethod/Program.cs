using System;

namespace MyFirstMethod
{
    class Program
    {

        /// <summary>
            /// Contagem crescente de 1 a 10
            /// </summary>
            private static void CountTo10()
            {
                for(int i = 1; i<=10; i++ )
                {
                    Console.WriteLine(i);
                }
            }
            /// <summary>
            /// Faz contagem crescente até ao valor indicado
            /// </summary>
            /// <param name="n">Valor final</param>
            static void CountToN(int n)
            {
                for(int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);

                }
            }

            /// <summary>
            /// Recebe dois numeros e faz contagem crescente
            /// </summary>
            /// <param name="n1">valor inicial</param>
            /// <param name="n2">valor final</param>
            private static void NtoN(int n1, int n2)
            {
                int i;
                for(i = n1; i<=n2; i++)
                {
                    Console.WriteLine(i);
                }

            }
        private static void Main(string[] args)
        {

            CountTo10();
            CountTo10();

            CountToN(8);
            CountToN(10);

            
           
            NtoN(2,3);

            }

    }
}
