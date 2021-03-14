using System;

namespace Task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            bool hasSameNumbers = false;

            if(a == 0 && b == 0)
            {
                Console.WriteLine("ДА");
                return;
            }

            if(a < 0 || b < 0)
            {
                if(a < 0)
                {
                    a = Math.Abs(a);
                }
                else
                {
                    b = Math.Abs(b);
                }
            }

            for (int i = a; i > 0; i /= 10)
            {
                for (int j = b; j > 0; j /= 10)
                {
                    if (i % 10 == j % 10)
                    {
                        hasSameNumbers = true;
                    }
                }
            }
            if (hasSameNumbers == true)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
        }
    }
}
