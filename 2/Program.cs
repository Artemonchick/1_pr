using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 2

            Console.Clear();
            Console.WriteLine("Игра \"21\"");

            Console.Write("Введите имя игрока: ");
            string name = Console.ReadLine();

            Console.Write($"Добро пожаловать в игру, {name}! \nВведите количество ваших карт: ");
            int summCard = Convert.ToInt32(Console.ReadLine());

            int num;
            int summ = 0;

            for (int i = 1; i <= summCard; i++)
            {
                Console.Write($"Введите номинал {i}-й карты: ");

                string pic = Console.ReadLine();

                if (pic == "J" || pic == "K")
                {
                    summ = summ + 10;
                }
                else if (pic == "Q" || pic == "T")
                {
                    summ = summ + 10;
                }
                else
                {
                    num = int.Parse(pic);
                    switch (num)
                    {
                        case 2:
                            {
                                summ = summ + 2;
                                break;
                            }
                        case 3:
                            {
                                summ = summ + 3;
                                break;
                            }
                        case 4:
                            {
                                summ = summ + 4;
                                break;
                            }
                        case 5:
                            {
                                summ = summ + 5;
                                break;
                            }
                        case 6:
                            {
                                summ = summ + 6;
                                break;
                            }
                        case 7:
                            {
                                summ = summ + 7;
                                break;
                            }
                        case 8:
                            {
                                summ = summ + 8;
                                break;
                            }
                        case 9:
                            {
                                summ = summ + 9;
                                break;
                            }
                        case 10:
                            {
                                summ = summ + 10;
                                break;
                            }
                        default:
                            {
                                summ = summ + 10;
                                break;
                            }
                    }
                }
            }

            Console.WriteLine($"Сумма ваших карт равна: {summ} ");
            Console.ReadKey();

            #endregion

        }
    }
}
