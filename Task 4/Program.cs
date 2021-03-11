using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = a - 1; i != 0; i--)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
