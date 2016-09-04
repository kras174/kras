﻿using System;
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

    class DoubleClass
    {
        int current = 1;
        int finish = 0;
        public int numberOfTry = 0;

        //Конструктор, в котором задаётся конечное число
        public DoubleClass (int n)
        {
            finish = n;
            numberOfTry = 0;
        }
        //Метод увеличивает текущее значение на 1
        public void IncreaseOne()
        {
            current += 1;
            numberOfTry++;
        }
        //Метод увеличивает текущее значение в 2 раза
        public void IncreaseTwo()
        {
            current *= 2;
            numberOfTry++;
        }
        //Метод сбрасывает текущее значение до 1
        public void ResetOne()
        {
            current = 1;
            numberOfTry++;
        }
        //Свойство возвращает текущее значение
        public int Current
        {
            get
            {
                return current;
            }
        }
        //Свойство возвращает конечное значение
        public int Finish
        {
            get
            {
                return finish;
            }
        }

    }
}
