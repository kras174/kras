using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание для урока №1:");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задание или нажмите любую другую клавишу для выхода:");
                Console.WriteLine("1. Сумматор.");
                Console.WriteLine("2. Анкета.");
                Console.WriteLine("3. Данные о зарплате.");

                var num = 0;
                num = int.Parse(Console.ReadLine());

                if (num == 1)   // расчёт суммы двух чисел
                {
                    int x = 0;
                    int y = 0;

                    Console.Clear();
                    Console.WriteLine("Сумматор.");
                    Console.WriteLine("Введите первое число:");
                    x = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    y = int.Parse(Console.ReadLine());

                    Console.WriteLine("Сумма чисел равна: " + (x+y));

                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadLine();

                }
                else if (num == 2)  // Анкета
                {
                    string name, surname, year, city, growth, weight;

                    Console.Clear();
                    Console.WriteLine("Анкета.");

                    Console.WriteLine("Введите имя:");
                    name = Console.ReadLine();

                    Console.WriteLine("Введите фамилию:");
                    surname = Console.ReadLine();

                    Console.WriteLine("Введите возраст:");
                    year = Console.ReadLine();

                    Console.WriteLine("Введите город рождения:");
                    city = Console.ReadLine();

                    Console.WriteLine("Введите рост:");
                    growth = Console.ReadLine();

                    Console.WriteLine("Введите вес:");
                    weight = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Введённые данные: " + surname + " " + name + ", Возраст: " + year + ", Город рождения: " + city + ", рост " + growth + ", вес " + weight);

                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadLine();


                }
                else if (num == 3)  // Расчёт зарплаты
                {
                    int payMonth = 0;
                    var n = 0;

                    Console.Clear();
                    Console.WriteLine("Данные о зарплате.");
                    Console.WriteLine("Введите зарплату за месяц:");
                    payMonth = int.Parse(Console.ReadLine());

                    Console.WriteLine("За какой срок определить зарплату:");
                    Console.WriteLine("1. Год.");
                    Console.WriteLine("2. Неделя.");
                    Console.WriteLine("3. Сутки.");
                    Console.WriteLine("4. Час.");
                    Console.WriteLine("5. Минута.");

                    n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            Console.WriteLine("Зарплата за год: " + Pay(n, payMonth));
                            break;
                        case 2:
                            Console.WriteLine("Зарплата за неделю: " + Pay(n, payMonth));
                            break;
                        case 3:
                            Console.WriteLine("Зарплата за сутки: " + Pay(n, payMonth));
                            break;
                        case 4:
                            Console.WriteLine("Зарплата за час: " + Pay(n, payMonth));
                            break;
                        case 5:
                            Console.WriteLine("Зарплата за минуту: " + Pay(n, payMonth));
                            break;
                        default:
                            Console.WriteLine("Зарплата за месяц: " + payMonth);
                            break;
                    }

                    Console.WriteLine("Нажмите любую клавишу для продолжения...");
                    Console.ReadLine();

                }
                else
                {
                    Console.Clear();
                    break;
                }

            }
        }

        static float Pay(int n, float p)    // Функция расчёта зарплаты по введённым данным
        {
            if (n == 1) p = p * 12;
            else if (n == 2) p = p / 4;
            else if (n == 3) p = p / 28;
            else if (n == 4) p = p / 672;
            else if (n == 5) p = p / 40320;

            return p;
        }
    }
}
