using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = string.Empty;

            Console.WriteLine("Введите логин");
            login = Console.ReadLine();
            //CheckLogin(login);
            CheckLoginReg(login);

            Console.ReadKey();
        }

        private static void CheckLoginReg(string login)
        {
            Regex reg = new Regex(@"^\D+[a-zA-Z0-9]{2,9}$");

            if (reg.IsMatch(login)) Console.WriteLine("Верный логин!");
            else Console.WriteLine("Неверный логин!");
        }

        private static void CheckLogin(string login)
        {
            bool isCorrect = false;

            if ((login.Length >= 2) && (login.Length <= 10))
            {
                foreach (char c in login)
                {
                    if ((char.IsLetter(c) || char.IsNumber(c)))
                    {
                        isCorrect = true;
                        continue;
                    }
                    else
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }

            if (isCorrect) Console.WriteLine("Верный логин!");
            else Console.WriteLine("Неверный логин!");
        }
    }
}
