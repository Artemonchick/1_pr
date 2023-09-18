using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine($"Число {N} - чётное ");
            }
            else
            {
                Console.WriteLine($"Число {N} - нечётное ");
            }
            Console.ReadKey();
        }
    }
}
