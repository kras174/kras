using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_N4_HW1
{
    class Program
    {
        //Дан целочисленныймассив из 20 элементов.Элементы массивамогут приниматьцелые значенияот –10 000 до 10 000 включительно.
        //Написать программу, позволяющуюнайти ивывести количествопар элементовмассива, в которыххотя быодно числоделится на 3. 
        //В даннойзадаче подпарой подразумеваетсядва подрядидущих элементамассива.
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
