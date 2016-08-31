using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N3_HW3
{
    //3.*Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    //   Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    //   Написать программу, демонстрирующую все разработанные элементы класса.
    //   Красильников Антон

    class Program
    {
        static void Main(string[] args)
        {
            //Оболочку для программы написать не успел, поэтому задаю дроби прям в коде:

            Fraction fr1 = new Fraction(2, 5);
            Fraction fr2 = new Fraction(5, 8);

            var result = fr1 + fr2;
            Console.WriteLine(result.ToString());

            result = fr1 - fr2;
            Console.WriteLine(result.ToString());

            result = fr1 * fr2;
            Console.WriteLine(result.ToString());

            result = fr1 / fr2;
            Console.WriteLine(result.ToString());


            Console.ReadKey();
        }
    }
}
