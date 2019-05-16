using System;
using System.Numerics;

namespace Calculate_
{
    class Program
    {
        static double NFactorial(int a)
        {
            double sum = 1;
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double S = 1;
            for (int i = 1; i <= N; i++)
            {
                S += NFactorial(i) / Math.Pow(x, i);
            }
            Console.WriteLine("{0:F5}", S);
        }
    }
}