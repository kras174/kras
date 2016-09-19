using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N6_HW1
{
    //Описываем делегат. В делегате описывается сигнатура(или прототип, как угодно) функций, на
    //которые сможет ссылатся делегат в дальнейшем
    public delegate double Fun(double x, double a);

    class Program
    {
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }

        static void Main(string[] args)
        {
            //Создаем новый делегат и передаем ссылку на него в метод Table. 
            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), -2, 3);//Параметры функции и тип возвращаемого значения, должны совпадать с делегатом
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            Table(MyFunc, -2, 3);//Упрощение(c C# 2.0). Делегат создается автоматически. 

            Console.ReadKey();
        }
    }
}
