using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int numbersQuantity = 0;

            for(int i = 1; i*i < a; i++)
            {
                numbersQuantity += 1;
            }

            Console.WriteLine($"Total: {numbersQuantity}");
        }
    }
}
