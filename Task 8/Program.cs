using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int start = 1;
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
                    start = mid;
                }
                else
                {
                    Console.WriteLine(mid);
                    break;
                }
            }
        }
    }
}
