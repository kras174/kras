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
            string password = string.Empty;

            //Console.WriteLine("Введите логин");
            //login = Console.ReadLine();
            //CheckLogin(login);
            //CheckLoginReg(login);

            Console.WriteLine("Введите пароль");
            password = Console.ReadLine();

            CheckPassword(password);

            Console.ReadKey();
        }

        //-----Метод проверяет сложность пароля
        private static void CheckPassword(string password)
        {
            /* Пароль должен быть от 3х символов и до 10
             * Пароль первой сложности только буквы или цифры
             * Пароль второй сложности и буквы и цифры
             * Пароль третей сложности строчные и заглавные буквы и цифры
             */
            Regex level1 = new Regex(@"^[a-z]|[0-9]{3,9}$");
            Regex level2 = new Regex(@"^[a-z0-9]{3,9}$");
            Regex level3 = new Regex(@"^[a-zA-Z0-9]{3,9}$");

            if (level1.IsMatch(password)) Console.WriteLine("Уровень пароля 1");
            else if (level2.IsMatch(password)) Console.WriteLine("Уровень пароля 2");
            else if (level3.IsMatch(password)) Console.WriteLine("Уровень пароля 3");

        }

        //-----Метод проверяет регуляркой корректность ввода логина. Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы и цифры, и при этом цифра не может быть первой.
        private static void CheckLoginReg(string login)
        {
            Regex reg = new Regex(@"^\D+[a-zA-Z0-9]{2,9}$");

            if (reg.IsMatch(login)) Console.WriteLine("Верный логин!");
            else Console.WriteLine("Неверный логин!");
        }

        //-----Метод проверяет корректность ввода логина. Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы и цифры, и при этом цифра не может быть первой.
        private static void CheckLogin(string login)
        {
            bool isCorrect = false;

            if ((login.Length >= 2) && (login.Length <= 10))
            {
                foreach (char c in login)
                {
                    if (char.IsNumber(c)) break;
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
