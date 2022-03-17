using System;

namespace Fibonacci
{
    class Program
    {
        private static int Fibo(int n)
        {
            int FiboValue;
            if((n == 0) ||(n == 1))
            {
                return n;
            }
            else
            {
                FiboValue = Fibo(n-1)+Fibo(n-2);
                return FiboValue;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fibo(8));
        }
    }
}
