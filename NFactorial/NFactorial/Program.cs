using System;
using System.Numerics;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger sum = new BigInteger();
            sum = BigInteger.Add(0, 1);
            for (int i = 1; i <= N; i++)
            {
                sum = BigInteger.Multiply(sum, i);
            }
            Console.WriteLine(sum);
        }
    }
}
