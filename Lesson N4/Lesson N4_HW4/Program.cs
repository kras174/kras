using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW4
{
    class Program
    {
        //Реализовать класс для работы с двумерным массивом.
        //Реализовать конструктор, заполняющий массив случайными числами. 
        //Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
        //свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
        //Красильников Антон

        static void Main(string[] args)
        {
            Matrix a = new Matrix(5,4);
            a.Print();
            Console.WriteLine("Сумма всех элементов массива равна: {0}", a.AllSum());
            Console.WriteLine("Сумма всех элементов массива больше 5 равна: {0}", a.AllSum(5));
            Console.WriteLine("Минимальный элемент массива: {0}", a.Min);
            Console.WriteLine("Максимальный элемент массива: {0}", a.Max);
            Console.WriteLine("Номер максимального элемента массива: {0}", a.NumMax());
            Console.ReadKey();
        }
    }
}
