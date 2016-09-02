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
            MyArray a = new MyArray(10, 0, 100);
            Console.WriteLine(a.CountPairs);

            Console.ReadKey();
        }
    }
}
