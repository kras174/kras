using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class MyData
    {
        private string date1;
        private string date2;
        private int year;
        private double days;

        public MyData(int n)
        {
            switch (n)
            {
                case 1:
                    Console.Clear();
                    var dateNow = DateTime.Now;
                    Console.WriteLine("Сейчас " + dateNow);
                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("Введите первую дату в формате гггг-мм-дд ");
                        date1 = Console.ReadLine();
                        Console.WriteLine("Введите вторую дату в формате гггг-мм-дд ");
                        date2 = Console.ReadLine();

                        CompareTwoDates(date1, date2);
                    }
                    catch
                    {
                        Console.WriteLine("Неверный формат!");
                    }
                    break;


                case 3:
                    try
                    {
                        Console.WriteLine("Введите год в формате гггг ");
                        year = Convert.ToInt32(Console.ReadLine());

                        WhatYearIs(year);
                    }
                    catch
                    {
                        Console.WriteLine("Неверный формат!");
                    }
                    break;

                default:
                    try
                    {
                        Console.WriteLine("Введите дату в формате гггг-мм-дд ");
                        date1 = Console.ReadLine();
                        Console.WriteLine("Сколько дней хотите прибавить?");
                        days = Convert.ToDouble(Console.ReadLine());

                        DatePlusDays(date1, days);
                    }
                    catch
                    {
                        Console.WriteLine("Неверный формат!");
                    }
                    break;
            }
        }

        //-----Прибавление к дате заданного колличества дней
        private void DatePlusDays(string date1, double days)
        {
            DateTime date = DateTime.Parse(date1);
            date = date.AddDays(days);
            Console.WriteLine("Результат: {0}", date);
        }

        //-----Определение високосного года
        private void WhatYearIs(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("Год {0} високосный!", year);
            }
            else Console.WriteLine("Год {0} невисокосный!", year);
        }

        //-----Разница в днях между датами (не могу понять почему не работает)
        private void CompareTwoDates(string date1, string date2)
        {
            DateTime dateFornat1 = DateTime.Parse(date1);
            DateTime dateFornat2 = DateTime.Parse(date2);
            TimeSpan dateCompareResult = dateFornat2.Date - dateFornat2.Date;

            Console.WriteLine("Результат: {0}", dateCompareResult.Days);
        }
    }
}
