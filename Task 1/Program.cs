using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double raisedToPower = 1;

            for(int i = 0; i < b; i++)
            {
                raisedToPower *= a;
            }

            Console.WriteLine(raisedToPower);
        }
    }
}
