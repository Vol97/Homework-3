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

            if (a == 0 && b < 0)
            {
                throw new DivideByZeroException("You tried to raise 0 to a negative power");
            }

            if (b < 0)
            {
                b *= -1;

                for (int i = 0; i < b; i++)
                {
                    raisedToPower *= a;
                }

                raisedToPower = 1 / raisedToPower;
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    raisedToPower *= a;
                }
            }

            Console.WriteLine(raisedToPower);
        }
    }
}
