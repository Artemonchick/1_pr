using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите длину последовательности: ");
            int length = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int num;

            Console.WriteLine("\nВведите числа: ");
            for (int i = 1; i <= length; i++)
            {
                Console.Write("");
                num = int.Parse(Console.ReadLine());
                if (num < min) min = num;

            }
            Console.WriteLine($"\nМинимальное число: {min}");
            Console.ReadKey();
        }
    }
}
