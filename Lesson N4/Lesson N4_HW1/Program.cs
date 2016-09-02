using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW1
{
    class Program
    {
        //Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
        //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
        //В данной задаче под парой подразумевается два подряд идущих элемента массива.
        //Красильников Антон

        static void Main(string[] args)
        {
            const int maxValue = 10000;
            const int minValue = -10000;
            string s = string.Empty;
            int count = 0;

            int[] arr = new int[20];
            Random rnd = new Random();
            for (int k = 0; k < arr.Length; k++)
                arr[k] = rnd.Next(minValue, maxValue);

            for (int k=0;k<arr.Length-1;k++)
            {
                if (arr[k] % 3 == 0 || arr[k + 1] % 3 == 0)
                    count++;
                s = s + arr[k] + " ";
            }

            Console.WriteLine(s);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
