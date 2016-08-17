using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    int n = 0;

                    Console.Clear();
                    Console.WriteLine("Выберите один из пунктов меню: \n 1. Ввести нового сотрудника. \n 2. Вывести список всех сотрудников. \n 3. Вывести средний уровень заработной платы. \n 4. Изменить должность сотрудника. \n 5. Изменить зарплату сотрудника. \n 6. Выход.");
                    n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            Console.Clear();
                            Employee worker = new Employee();
                            break;
                        case 2:
                            Console.Clear();
                            Employee.ShowInfo();
                            break;
                        case 3:
                            Console.Clear();
                            Employee.AveragePayment();
                            break;
                        case 4:
                            Console.Clear();
                            Employee.ChangePosition();
                            break;
                        case 5:
                            Console.Clear();
                            Employee.ChangePayment();
                            break;
                        default:
                            break;
                    }

                    if (n >= 6 || n == 0) break;

                    Console.WriteLine("Для возврата в меню нажмите любую клавишу...");
                    Console.ReadLine();
                }
                catch 
                {
                    Console.WriteLine("Введено неверное значение");
                }

            }
        }
    }
}
