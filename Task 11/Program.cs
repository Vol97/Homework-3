using System;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfEven = 0;
                int sumOfOdd = 0;

                for (int number = i; number > 0; number /= 10)
                {
                    if ((number % 10) % 2 == 0)
                    {
                        sumOfEven += number % 10;
                    }
                    else
                    {
                        sumOfOdd += number % 10;
                    }
                }

                if (sumOfEven > sumOfOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
