using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int number;
            int sumOdd = 0, sumEven = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                number = numbers[i];
                sumOdd = 0;
                sumEven = 0;
                for (int j = 0; j < 4; j++)
                {
                    if ((number % 10) % 2 == 0) sumEven += number % 10;
                    else sumOdd += number % 10;
                    number /= 10;
                }
                if (sumOdd > sumEven) Console.WriteLine("right");
                else if (sumOdd < sumEven) Console.WriteLine("left");
                else if (sumOdd == sumEven) Console.WriteLine("straight");
            }
        }
    }
}
