using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            bool num = false;
            int i = 2;

            while (i <= N - 1)
            {
                int balance = N % i;
                i++;
                if (balance == 0)
                {
                    num = true;
                    break;
                }

            }
            if (num == false)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не является простым");
            }
            Console.ReadKey();
        }
    }
}
