using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                throw new ArgumentException("Not a positive number");
            }

            int start = 0;
            int end = a;

            while (true)
            {
                int mid = (start + end) / 2;

                if (Math.Pow(mid, 3) > a)
                {
                    end = mid;
                }
                else if (Math.Pow(mid, 3) < a)
                {
                    start = mid + 1;
                }
                else
                {
                    Console.WriteLine(mid);
                    break;
                }

                if (start == end)
                {
                    Console.WriteLine("oops");
                    break;
                }
            }
        }
    }
}
