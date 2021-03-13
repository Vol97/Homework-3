using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                throw new DivideByZeroException();
            }
            else if (a < 0)
            {
                a *= -1;
            }

            for (int i = a; i <= 1000; i += a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
