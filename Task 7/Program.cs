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

            if (a == 0 && b == 0)
            {
                result = 0;
            }
            else if (a == 0 || b == 0)
            {
                if (a == 0)
                {
                    result = Math.Abs(b);
                }
                else
                {
                    result = Math.Abs(a);
                }
            }
            else if (a < 0 || b < 0)
            {
                if (a < 0)
                {
                    a = Math.Abs(a);
                }
                if (b < 0)
                {
                    b = Math.Abs(b);
                }
            }

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
