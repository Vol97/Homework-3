using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fibonacciN1 = 1;
            int fibonacciN2 = 1;
            int fibonacciN = 0;

            if (n < 0)
            {
                Console.WriteLine("oops");
            }
            else if (n > 0 && n <= 2)
            {
                Console.WriteLine($"{n} number in the Fibonacci sequence: {fibonacciN1}");
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    fibonacciN = fibonacciN1 + fibonacciN2;
                    fibonacciN1 = fibonacciN2;
                    fibonacciN2 = fibonacciN;
                }
                Console.WriteLine($"{n} number in the Fibonacci sequence: {fibonacciN}");
            }
            
        }
    }
}
