using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10_pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1

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

            #endregion

            #region Задание 2

            //Console.Clear();
            //Console.WriteLine("Игра \"21\"");

            //Console.Write("Введите имя игрока: ");
            //string name = Console.ReadLine();

            //Console.Write($"Добро пожаловать в игру, {name}! \nВведите количество ваших карт: ");
            //int summCard = Convert.ToInt32(Console.ReadLine());

            //int num;
            //int summ = 0;

            //for (int i = 1; i <= summCard; i++)
            //{
            //    Console.Write($"Введите номинал {i}-й карты: ");

            //    string pic = Console.ReadLine();

            //    if (pic == "J" || pic == "K")
            //    {
            //        summ = summ + 10;
            //    }
            //    else if (pic == "Q" || pic == "T")
            //    {
            //        summ = summ + 10;
            //    }
            //    else
            //    {
            //        num = int.Parse(pic);
            //        switch (num)
            //        {
            //            case 2:
            //                {
            //                    summ = summ + 2;
            //                    break;
            //                }
            //            case 3:
            //                {
            //                    summ = summ + 3;
            //                    break;
            //                }
            //            case 4:
            //                {
            //                    summ = summ + 4;
            //                    break;
            //                }
            //            case 5:
            //                {
            //                    summ = summ + 5;
            //                    break;
            //                }
            //            case 6:
            //                {
            //                    summ = summ + 6;
            //                    break;
            //                }
            //            case 7:
            //                {
            //                    summ = summ + 7;
            //                    break;
            //                }
            //            case 8:
            //                {
            //                    summ = summ + 8;
            //                    break;
            //                }
            //            case 9:
            //                {
            //                    summ = summ + 9;
            //                    break;
            //                }
            //            case 10:
            //                {
            //                    summ = summ + 10;
            //                    break;
            //                }
            //            default:
            //                {
            //                    summ = summ + 10;
            //                    break;
            //                }
            //        }
            //    }
            //}

            //Console.WriteLine($"Сумма ваших карт равна: {summ} ");
            //Console.ReadKey();

            #endregion

            #region Задание 3

            //Console.Clear();
            //Console.Write("Введите число: ");
            //int N = Convert.ToInt32(Console.ReadLine());
            //bool num = false;
            //int i = 2;

            //while (i <= N - 1)
            //{
            //    int balance = N % i;
            //    i++;
            //    if (balance == 0)
            //    {
            //        num = true;
            //        break;
            //    }

            //}
            //if (num == false)
            //{
            //    Console.WriteLine("Число простое");
            //}
            //else
            //{
            //    Console.WriteLine("Число не является простым");
            //}
            //Console.ReadKey();

            #endregion

            #region Задание 4

            //Console.Clear();
            //Console.Write("Введите длину последовательности: ");
            //int length = int.Parse(Console.ReadLine());
            //int min = int.MaxValue;
            //int num;

            //Console.WriteLine("\nВведите числа: ");
            //for (int i = 1; i <= length; i++)
            //{
            //    Console.Write("");
            //    num = int.Parse(Console.ReadLine());
            //    if (num < min) min = num;

            //}
            //Console.WriteLine($"\nМинимальное число: {min}");
            //Console.ReadKey();

            #endregion

            #region Задание 5

            //Console.Clear();
            //Console.Write("Введите максимальное число: ");
            //int max = int.Parse(Console.ReadLine());

            //Random num = new Random();
            //int rand = num.Next(0, max + 1);
            //Console.Write("\nУгадайте число или нажмите Enter, чтобы выйти: ");

            //while (1 == 1)
            //{
            //    string exit = Console.ReadLine();
            //    if (exit == string.Empty)
            //    {
            //        Console.WriteLine($"\nЗагаданное число: {rand}");
            //        break;
            //    }

            //    int magic = int.Parse(exit);
            //    if (magic < rand)
            //    {
            //        Console.WriteLine("\nВведённое число меньше загаданного. Попробуйте ещё раз! ");
            //    }
            //    else if (magic > rand)
            //    {
            //        Console.WriteLine("\nВведённое число больше загаданного. Попробуйте ещё раз! ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("\nВы угадали число! ");
            //        break;
            //    }
            //}
            //Console.ReadLine();

            #endregion
        }
    }
}
