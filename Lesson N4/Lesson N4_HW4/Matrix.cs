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

        //Конструктор, заполняющий массив случайными числами. 
        public Matrix (int n,int m)
        {
            matrix = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(1,100);
        }
        //Выводит матрицу на экран
        public void Print()
        {
            for (int i=0;i<matrix.GetLength(0);i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,4}", matrix[i, j]);
                Console.WriteLine();
            }
        }
        //Методы возвращающие сумму всех элементов массива
        public int AllSum()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    sum += matrix[i, j];
            return sum;
        }
        public int AllSum(int n)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] > n) sum += matrix[i, j];
            return sum;
        }
        //Свойство, возвращающее минимальный элемент массива
        public int Min
        {
            get
            {
                int min = int.MaxValue;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (matrix[i, j] < min) min = matrix[i, j];
                return min;
            }
        }
        //Свойство, возвращающее минимальный элемент массива
        public int Max
        {
            get
            {
                int max = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        if (matrix[i, j] > max) max = matrix[i, j];
                return max;
            }
        }
        //Метод, возвращающий номер максимального элемента массива
        public string NumMax()
        {
            int x = 0;
            int y = 0;
            string s = string.Empty;
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == Max)
                    {
                        x = i+1;
                        y = j+1;
                    }
             return s = "matrix[" + x + "," + y + "]";
        }
    }
}
