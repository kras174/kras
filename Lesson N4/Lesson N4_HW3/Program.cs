using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW3
{
    //* Существует алгоритмическая игра “Удвоитель”. В этой игре человеку предлагается какое-­то число, а человек должен, управляя роботом “Удвоитель”, достичь этого числа за минимальное число шагов.
    //  Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и сбросить число до 1. Начальное значение удвоителя равно 1. Реализовать класс “Удвоитель”. Класс хранит в 
    //  себе поле current­ текущее значение, finish­ число, которого нужно достичь, конструктор, в котором задается конечное число.Методы: увеличить числона 1, увеличить число в два раза, сброс 
    //  текущего до 1, свойство Current, которое возвращает текущее значение, свойство Finish, которое возвращает конечное значение.Создать с помощью этого класса игру, в которой компьютер загадывает 
    //  число, а человек, выбирая из меню на экране, отдает команды удвоителю и старается получить это число за наименьшее число ходов. Если человек получает число больше положенного, игра прекращается. 
    // Красильников Антон

    class Program
    {
        static void Main(string[] args)
        {
            int currentState = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Добро пожаловать в игру удвоитель! \n Для начала нажмите 1, для выхода 0. \n 1.Начать игру. \n 0.Выход.");
                try
                {
                    currentState = int.Parse(Console.ReadLine());
                    if (currentState == 1)
                    {
                        Random rnd = new Random();
                        DoubleClass num = new DoubleClass(rnd.Next(2, 20));
                        do
                        {
                            if (num.Current > num.Finish)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы проиграли! =( Текущее число {0} превысило загаданное Удвоителем число {1}", num.Current,num.Finish);
                                Console.WriteLine("Для возврата в меню нажмите любую клавишу...");
                                Console.ReadKey();
                                break;
                            }
                            Console.Clear();
                            Console.WriteLine("Удвоитель загадал для вас число: {0}", num.Finish);
                            Console.WriteLine("Начальное значение равно: {0}", num.Current);
                            Console.WriteLine("Что хотите сделать с числом: \n 1.Увеличить число на 1. \n 2.Увеличить число в 2 раза. \n 3.Сбросить число до 1. \n 0.Выход.");
                            currentState = int.Parse(Console.ReadLine());
                            if (currentState == 1)
                                num.IncreaseOne();
                            else if (currentState == 2)
                                num.IncreaseTwo();
                            else if (currentState == 3)
                                num.ResetOne();
                            else break;
                        }
                        while (num.Current != num.Finish);
                        if (num.Current == num.Finish)
                        {
                            Console.Clear();
                            Console.WriteLine("Вы победили!");
                            Console.WriteLine("Колличество ходов: {0}", num.numberOfTry);
                            Console.WriteLine("Для возврата в меню нажмите любую клавишу...");
                            Console.ReadKey();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (currentState != 0);
        }
    }
}
