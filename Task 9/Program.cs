using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int number;
            int oddNumbers = 0;

            while (n % 10 != 0)
            {
                number = n % 10;

                if (number % 2 != 0)
                {
                    oddNumbers++;
                }
                n /= 10;
            }
            Console.WriteLine($"Overall odd numbers: {oddNumbers}");
        }
    }
}
