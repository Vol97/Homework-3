using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string mirrorNumberAsString = string.Empty;
            int mirrorNumber;

            while(n % 10 != 0)
            {
                mirrorNumberAsString += n % 10;
                n /= 10;
            }

            mirrorNumber = Convert.ToInt32(mirrorNumberAsString);
            Console.WriteLine(mirrorNumber);
        }
    }
}
