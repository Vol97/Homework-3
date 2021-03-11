using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    result = b;
                    a = a % b;
                }
                else
                {
                    result = a;
                    b = b % a;
                }
            }

            Console.WriteLine($"Greatest common divisor of given numbers is {result}");
        }
    }
}
