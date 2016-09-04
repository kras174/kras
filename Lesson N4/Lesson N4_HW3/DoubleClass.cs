using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW3
{
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
