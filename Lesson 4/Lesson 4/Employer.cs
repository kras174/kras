using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Employer
    {
        string name;
        string position;
        int payment;
        int value;

        string[] positions = { "Директор", "Зам директора", "Главный бухгалтер", "Бухгалтер", "Менеджер", "Программист", "Охранник", "Уборщица"};

        public static List<object> emploers = new List<object>();

        public Employer()
        {
            Console.WriteLine("Введите полное имя сотрудника");
            name = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Выберите должность сотрудника из списка: \n");
                for(var i=0;i<=positions.Length-1;i++)
                {
                    Console.WriteLine("{0}. {1}.\n", i + 1, positions[i]);
                }
                if (ifNum()) { position = positions[value-1]; break; }
                else { Console.WriteLine("Должность сотрудника должна быть введена в виде числа."); }
            }

            while (true)
            {
                Console.WriteLine("Введите начальную  зарплату сотрудника: ");
                if (ifNum()) { payment = value; break; }
                else { Console.WriteLine("Зарплата сотрудника должна быть введена в виде числа."); }
            }

            emploers.Add(this);
        }

        static public void ShowInfo()
        {
            foreach (Employer c in emploers)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Сотрудник: {0}, должность: {1}, зарплата: {2} рублей.", c.name, c.position, c.payment);
                Console.WriteLine(" ");

            }
        }

        public void ChangePosition()
        {

        }

        public void ChqngePayment()
        {

        }

        private bool ifNum()
        {
            string a = string.Empty;
            int i;
            a = Console.ReadLine();
            if (int.TryParse(a, out i)) { value = i; return true;}
            else { Console.WriteLine("Это не число!"); return false;}
        }
    }
}
