using System;

namespace PrimeTriangle
{
    class Program
    {
        public static int IsPrime(double n)
        {
            int i = 2;
            if (n == 2) return 1;
            while (i <= Math.Sqrt(n))
            {
                if (n % i == 0) return 0;
                i++;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string output = null;
            for (int i = 1; i <= N; i++)
            {
                output += IsPrime(i);
                if (output[output.Length - 1] == '1')
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}