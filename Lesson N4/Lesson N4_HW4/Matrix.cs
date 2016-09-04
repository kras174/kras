using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW4
{
    //Реализовать класс для работы с двумерным массивом.
    //Реализовать конструктор, заполняющий массив случайными числами. 
    //Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее минимальный элемент массива, 
    //свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
    //Красильников Антон

    class Matrix
    {
        int[, ] matrix;

        public Matrix (int n,int m)
        {
            matrix = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(0,10);
        }

        public void Print()
        {
            for (int i=0;i<matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,4}", matrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}
