using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2D
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            double dec = 0;
            int pow = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                int number = (int)Char.GetNumericValue(input[i]);
                dec += number * Math.Pow(2, pow);
                pow--;
            }
            Console.WriteLine(dec);
        }
    }
}