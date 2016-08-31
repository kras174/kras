using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N3_HW2
{
    //2.С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    //Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран;
    //Добавить обработку исключительных ситуаций на то, что могут быть введены не корректные данные.При возникновении ошибки вывести сообщение. 
    //Красильнмиков Антон

    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int result = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите любое число или 0 для подсчёта резултата");
                    num = int.Parse(Console.ReadLine());
                    if (num == 0)
                    {
                        Console.WriteLine("Сумма всех нечётных положительных чисел равна: {0}", result);
                        Console.ReadKey();
                        break;
                    }
                    if ((num > 0) && (num % 2 != 0))
                        result += num;
                }
                catch (FormatException ex)
                {
                    Console​.WriteLine​("Неверный формат данных!");
                    //Console.WriteLine(ex.Message);
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода! Попробуйте ещё раз!");
                }
            }
        }
    }
}
