using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите максимальное число: ");
            int max = int.Parse(Console.ReadLine());

            Random num = new Random();
            int rand = num.Next(0, max + 1);
            Console.Write("\nУгадайте число или нажмите Enter, чтобы выйти: ");

            while (1 == 1)
            {
                string exit = Console.ReadLine();
                if (exit == string.Empty)
                {
                    Console.WriteLine($"\nЗагаданное число: {rand}");
                    break;
                }

                int magic = int.Parse(exit);
                if (magic < rand)
                {
                    Console.WriteLine("\nВведённое число меньше загаданного. Попробуйте ещё раз! ");
                }
                else if (magic > rand)
                {
                    Console.WriteLine("\nВведённое число больше загаданного. Попробуйте ещё раз! ");
                }
                else
                {
                    Console.WriteLine("\nВы угадали число! ");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
