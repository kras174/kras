using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        //Для работы программы нужно раскамментить соответвсующий код в Main

        static void Main(string[] args)
        {
            //--Задание 1 из методички
            //int a, b, c;
            //a = inData(1);
            //b = inData(2);
            //c = inData(3);
            //Console.WriteLine("Минимальное из этих чисел: " + Minimum(a, b, c));
            //----------------------------------------------------------------------

            //--Задание 2 из методички
            //int a;
            //a = inData(1);
            //Console.WriteLine("Колличество цифр числа равно: " + countNum(a));
            //----------------------------------------------------------------------

            //--Задание 3 из методички
            //SumPosNum();
            //----------------------------------------------------------------------

            //--Домашнее задание А. Авторизация пользователя
            //Authorization user1 = new Authorization();
            //user1.startAuthorization(2); // 1-авторизация из программы; 2-авторизация из файла.
            //Console.WriteLine("Нажмите любую клавишу...");
            //----------------------------------------------------------------------

            //--Домашнее задание B. Простой калькулятор
            //int a, b;
            //a = inData(1);
            //b = inData(2);
            //Calculator(a,b);
            //----------------------------------------------------------------------

            //--Домашнее задание D. Перевод числа из десятичной системы счисления в двоичную.
            //int a;
            //a = inData(1);
            //Console.WriteLine("Результат перевода числа в двоичную систему счисления: " + Substitution(a));

            //--Домашнее задание C. Реализовать собственную структуру «Дата».

            Console.WriteLine("Выберите пункт меню: ");
            Console.WriteLine("1. Показать текущую дату и время.");
            Console.WriteLine("2. Разница между двумя датами.");
            Console.WriteLine("3. Определение високосного года.");
            Console.WriteLine("4. Прибавление к дате определенного числа дней.");

            int n = Convert.ToInt32(Console.ReadLine());

            MyData date1 = new MyData(n);

            Console.ReadLine();
        }

        //-----Данный метод запрашивает у пользователя число с порядковым номером 'АBC', проверяет число ли это, и возвращает его 
        static int inData(int ABC) 
        {
            string a = string.Empty;
            int i, x;

            while (true)
            {
                Console.WriteLine("Введите число #" + ABC + ": ");
                a = Console.ReadLine();
                if (int.TryParse(a, out i)) { x = int.Parse(a); break; }
                else { Console.WriteLine("Это не число!"); continue; }
            }

            return x;
        }

        //-----Вычисляет минимальное из трёх чисел (задание из методички)
        static int Minimum (int a, int b, int c)    
        {

            if ((a < b) && (a < c))
                return a;
            else if ((b < a) && (b < c))
                return b;
            else 
                return c;
        }

        //-----Метод подсчёта колличества цифр числа (задание из методички)
        static int countNum (int x) 
        {
            int y;
            string s;

            s = x.ToString();
            y = s.Length;

            return y;
        }

        //-----Сумма всех нечётных положительных чисел (задание из методички)
        static void SumPosNum ()    
        {
            int i = 1;
            int n, result = 0;

            do
            {
                n = inData(i);
                if ((n > 0) && (n % 2 != 0)) result += n;

                i++;
            }
            while (n != 0);

            Console.WriteLine("Сумма всех нечётных положительных чисел равна: " + result);
        }

        //-----Простой калькулятор
        static void Calculator(int a, int b)
        {
            var result = 0;
            char c = ' ';
            Console.WriteLine("Введите знак операции над числами (+,-,*,/): ");
            c = Convert.ToChar(Console.ReadLine());
            if (c == '+')
            {
                result = a + b;
                Console.WriteLine("Сумма равна: " + result);
            }
            else if (c == '-')
            {
                result = a - b;
                Console.WriteLine("Разность равна: " + result);
            }
            else if (c == '*')
            {
                result = a * b;
                Console.WriteLine("Умножение равно: " + result);
            }
            else if (c == '/')
            {
                if (b != 0)
                {
                    result = a / b;
                    Console.WriteLine("Деление равно: " + result);
                }
                else Console.WriteLine("На ноль делить нельзя!");
            }
            else Console.WriteLine("Нет такой операции!");
        }

        //-----Перевод числа из десятичной системы счисления в двоичную. "Алгоритм замещения".
        static string Substitution (double n)
        {
            var result = new List<int>();
            string resultGood = string.Empty;

            do
            {
                if (n % 2 == 1) result.Add(1);
                else result.Add(0);
                n = Math.Truncate(n / 2);
            }
            while (n != 1);
            result.Add(1);

            int listLength = result.Count;

            for (int i = listLength-1; i >= 0; i--)
            {
                resultGood += result[i];
            }

            return resultGood;
        }

        //-----Программу, печатающая все подмножества множества {1, 2,...,N}. К сожалению не хватило времени на выполнение.
        static void Subset(int n)
        {
            
        }
    }
}
