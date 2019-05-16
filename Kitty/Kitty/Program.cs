using System;

namespace Kitty
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            string inputP = Console.ReadLine();
            string[] elems = inputP.Split(' ');
            int[] path = new int[elems.Length];

            for (int i = 0; i < elems.Length; i++)
            {
                path[i] = int.Parse(elems[i]);
            }

            int jumps = 0;
            int index = 0;
            int coderSouls = 0;
            int food = 0;
            int deadlocks = 0;

            for (int i = 0; i <= path.Length; i++)
            {
                if (input[index] == 'x')
                {
                    if (index % 2 == 0)
                    {
                        coderSouls--;
                        input[index] = '@';
                        if (coderSouls < 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock:" + jumps);
                            break;
                        }
                    }
                    else if (index % 2 != 0)
                    {
                        food--;
                        input[index] = '*';
                        if (food < 0)
                        {
                            Console.WriteLine("You are deadlocked, you greedy kitty!");
                            Console.WriteLine("Jumps before deadlock:" + jumps);
                            break;
                        }
                    }
                    deadlocks++;
                }

                else if (input[index] == '@')
                {
                    coderSouls++;
                    input[index] = '0';
                }

                else if (input[index] == '*')
                {
                    food++;
                    input[index] = '0';
                }

                jumps++;

                if (i == path.Length)
                {
                    Console.WriteLine("Coder souls collected:" + coderSouls);
                    Console.WriteLine("Food collected:" + food);
                    Console.WriteLine("Deadlocks:" + deadlocks);
                    break;
                }

                index += path[i];

                while (index < 0)
                {
                    index += input.Length;
                }

                while (index > input.Length - 1)
                {
                    index -= input.Length;
                }
            }
        }
    }
}
