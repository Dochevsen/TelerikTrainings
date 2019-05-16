using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int b = 1;
            int currentStreak = 1;
            int maxStreak = 0;
            int[] input = new int[N];
            for (int i = 0; i < N; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            int number = input[0];
            for (int i = 1; i < N; i++)
            {
                if (number < input[i])
                {
                    b++;
                    currentStreak = b;
                    if (currentStreak > maxStreak)
                    {
                        maxStreak = currentStreak;
                    }
                }
                else
                {
                    b = 1;
                    currentStreak = b;
                }
                number = input[i];
            }
            Console.WriteLine(maxStreak);
        }
    }
}
