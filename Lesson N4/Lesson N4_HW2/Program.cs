using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW2
{
    //Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами 
    //от начального значения с заданным шагом.Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех 
    //элементов массива,  Метод Multi, умножающий каждый элемент массива на определенное число, метод MaxCounter и свойство MaxCount, 
    //возвращающее количество максимальных элементов.В Main продемонстрировать работу класса.
    //Красильников Антон

    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray(10, 2, "5");
            Console.WriteLine(a.ToString());

            Console.WriteLine("Количество пар элементов массива, в которых хотя бы одно число делится на 3 = {0}", a.CountPairs);
            Console.WriteLine("Сумма элементов массива = {0}", a.Sum);

            a.Inverse();
            Console.WriteLine(a.ToString());

            a.Multi(10);
            Console.WriteLine(a.ToString());

            Console.ReadKey();
        }
    }
}
