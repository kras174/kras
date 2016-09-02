﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW2
{
    class MyArray
    {
        int[] a;
        //---Из методички---Создание массива и заполнение его одним значением el
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //---Из методички---Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        //---Из методички---Свойство получает максимальный элемент массива
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        //---Из методички---Свойство получает минимальный элемент массива
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        //---Из методички---Свойство подчитывает колличество положительных элементов массива
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        //---Из методички---Вывод массива в консоль в удобночитаемом виде
        public override string ToString()
        {
            string s = string.Empty;
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        //---Домашнее задание 1---Свойство возвращает количество пар элементов массива, в которых хотя бы одно число делится на 3.
        public int CountPairs
        {
            get 
            {
                int count = 0;
                for (int k = 0; k < a.Length - 1; k++)
                {
                    if (a[k] % 3 == 0 || a[k + 1] % 3 == 0)
                        count++;
                }
                return count;
            }
        }
    }
}
