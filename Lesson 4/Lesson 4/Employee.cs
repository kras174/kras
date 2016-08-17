using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Employee
    {
        public int id;
        public string name;
        public string surname;
        public string patronymic;
        public string fullName;
        public string position;
        public double salary;
        public bool isFired = false;
        public DateTime? dateHired;
        public DateTime? dateFired;

        static int value;

        static string[] positions = { "Директор", "Зам директора", "Главный бухгалтер", "Бухгалтер", "Менеджер", "Программист", "Охранник", "Уборщица"};

        public static List<object> EmployeeList = new List<object>(); //База данных всех сотрудников

        //-----Конструктор
        public Employee()
        {
            Console.WriteLine("Введите ФИО сотрудника через пробел: ");
            fullName = Console.ReadLine();

            string[] substrings = fullName.Split(' ');

            surname = substrings[0];
            name = substrings[1];
            patronymic = substrings[2];

            while (true)
            {
                Console.WriteLine("Выберите должность сотрудника из списка:");
                for(var i=0;i<=positions.Length-1;i++)
                {
                    Console.WriteLine("{0}. {1}.", i + 1, positions[i]);
                }
                if (ifNum()) { position = positions[value-1]; break; }
                else { Console.WriteLine("Должность сотрудника должна быть введена в виде числа."); }
            }

            while (true)
            {
                Console.WriteLine("Введите начальную  зарплату сотрудника: ");
                if (ifNum()) { salary = value; break; }
                else { Console.WriteLine("Зарплата сотрудника должна быть введена в виде числа."); }
            }

            dateHired = DateTime.Now;
            dateFired = null;

            id = EmployeeList.Count+1;

            EmployeeList.Add(this);

        }

        //-----Метод выводит полный список сотрудников, их должности и зарплаты
        static public void ShowInfo()
        {
            foreach (Employee c in EmployeeList)
            {
                Console.WriteLine("{0}, должность: {1}, зарплата: {2} рублей. Работает с {3}.", c.fullName, c.position, c.salary, c.dateHired);
            }

        }

        //-----Метод позволяет изменить должность любого сотрудника из списка
        static public void ChangePosition()
        {
            int emploerNumber;
            string newPosition;
            int count = 1;

            while (true)
            {
                Console.WriteLine("Выберите сотрудника из списка чью должность вы хотите изменить:");
                foreach (Employee c in EmployeeList)
                {
                    Console.WriteLine("{0}. {1}", count, c.fullName);
                    count++;
                }
                if (ifNum()) { emploerNumber = value; break; }
                else { Console.WriteLine("Должность сотрудника должна быть введена в виде числа."); }
            }
            while (true)
            {
                Console.WriteLine("Выберите новую должность сотрудника из списка:");
                for (var i = 0; i <= positions.Length - 1; i++)
                {
                    Console.WriteLine("{0}. {1}.", i + 1, positions[i]);
                }
                if (ifNum()) { newPosition = positions[value - 1]; break; }
                else { Console.WriteLine("Должность сотрудника должна быть введена в виде числа."); }
            }

            foreach (Employee c in EmployeeList)
            {
                if (emploerNumber == c.id)
                {
                    c.position = newPosition;
                    break;
                }
            }
        }

        //-----Метод позволяет изменить зарплату любого сотрудника из списка
        static public void ChangePayment()
        {
            int emploerNumber;
            int newPayment;
            int count = 1;

            while (true)
            {
                Console.WriteLine("Выберите сотрудника из списка чью зарплату вы хотите изменить:");
                foreach (Employee c in EmployeeList)
                {
                    Console.WriteLine("{0}. {1}", count, c.fullName);
                    count++;
                }
                if (ifNum()) { emploerNumber = value; break; }
                else { Console.WriteLine("Должность сотрудника должна быть введена в виде числа."); }
            }
            while (true)
            {
                Console.WriteLine("Введите новую зарплату сотрудника:");
                if (ifNum()) { newPayment = value; break; }
                else { Console.WriteLine("Зарплата сотрудника должна быть введена в виде числа."); }
            }

            foreach (Employee c in EmployeeList)
            {
                if (emploerNumber == c.id)
                {
                    c.salary = newPayment;
                    break;
                }
            }
        }

        //-----Метод расчитывает средний уровень заработной платы
        static public void AveragePayment()
        {
            double averagePayment = 0;

            foreach (Employee c in EmployeeList)
            {
                averagePayment += c.salary;
            }

            averagePayment = averagePayment / EmployeeList.Count;

            Console.WriteLine("Средняя зарплата всех сотрудников равна: {0} рублей.", averagePayment);
        }
        
        //-----Метод расчитывает общую зарплату всех сотрудников
        static public void TotalPayment()
        {
            double totalPayment = 0;

            foreach (Employee c in EmployeeList)
            {
                totalPayment += c.salary;
            }

            Console.WriteLine("Общая зарплата всех сотрудников равна: {0} рублей.", totalPayment);
        }

        //-----Метод проверяет введено ли число в консоль и записывает его в value
        static private bool ifNum()
        {
            string a = string.Empty;
            int i;
            a = Console.ReadLine();
            if (int.TryParse(a, out i)) { value = i; return true;}
            else { Console.WriteLine("Это не число!"); return false;}
        }
    }
}
