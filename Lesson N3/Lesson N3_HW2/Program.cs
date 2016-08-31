using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N3_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int result = 0;

            while (true)
            {
                Console.WriteLine("Введите любое число или 0 для выхода");
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num == 0) break;
                    if ((num > 0))
                    {
                        result += num;
                    }
                }
                catch (FormatException ex)
                {
                    Console​.WriteLine​(​"Не правильно ввели данные"​);                  
                    ​Console.WriteLine(​ex.Message);
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода! Попробуйте ещё раз!");
                }
            }

        }
    }
}
