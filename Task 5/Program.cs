using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp;
            int sum = 0;

            if (b < a)
            {
                temp = a;
                a = b;
                b = temp;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Total sum: {sum}");

        }
    }
}
