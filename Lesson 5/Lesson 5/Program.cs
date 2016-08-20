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
            string message = string.Empty;

            //---Задание 1 домашней работы
            //Console.WriteLine("Введите логин");
            //login = Console.ReadLine();
            //CheckLogin(login);
            //CheckLoginReg(login);

            //---Задание 1.1 домашней работы
            //Console.WriteLine("Введите пароль");
            //password = Console.ReadLine();
            //CheckPassword(password);

            Console.WriteLine("Введите сообщение");
            message = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Что хотим сделать с сообщением:");
            Console.WriteLine("1. Вывести только те слова сообщения, которые содержат не более чем n букв;");
            Console.WriteLine("2. Удалить из сообщения все слова, которые заканчиваются на заданный символ;");
            Console.WriteLine("3. Найти самое длинное слово сообщения;");
            Console.WriteLine("4. Найти все самые длинные слова сообщения.");

            try
            {
                int num = int.Parse(Console.ReadLine());

                switch(num)
                {
                    case 1:
                        NoLongerThenN(message);
                        break;
                    case 2:
                        DeleteThatEndsOnN(message);
                        break;
                    case 3:
                        LongerWord(message);
                        break;
                    default:
                        AllLongerWords(message);
                        break;
                }
            }
            catch { }

            Console.ReadLine();
        }

        //-----Самые длинные слова сообщения;
        private static void AllLongerWords(string message)
        {
            string[] words = message.Split(' ');
            string longestWords = string.Empty;
            int count = 0;

            Console.Clear();
            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i].Length > count) count = words[i].Length;
            }

            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i].Length == count) longestWords += words[i] + ' ';
            }

            Console.WriteLine("Все самые длинные слова: {0}", longestWords);
        }
        //-----Самое длинное слово сообщения;
        private static void LongerWord(string message)
        {
            string[] words = message.Split(' ');
            string longestWord = string.Empty;
            int count = 0;

            Console.Clear();
            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i].Length > count) longestWord = words[i]; count = words[i].Length;
            }

            Console.WriteLine("Самое длинное слово: {0}", longestWord);
        }

        //-----Удаляет из сообщения все слова, которые заканчиваются на заданный символ;
        private static void DeleteThatEndsOnN(string message)
        {
            string[] words = message.Split(' ');
            string newMessage = string.Empty;

            Console.Clear();
            Console.WriteLine("Введите символ: ");
            var n = Console.ReadLine();

            for (int i = 0; i <= words.Length-1; i++)
            {
                if (!words[i].EndsWith(n.ToString())) newMessage += words[i] + ' ';
            }

            Console.WriteLine(newMessage);
        }

        //-----Выводит только те слова сообщения, которые содержат не более чем n букв;
        private static void NoLongerThenN(string message)
        {
            string[] words = message.Split(' ');

            Console.Clear();
            Console.WriteLine("Введите число букв: ");
            var n = int.Parse(Console.ReadLine());

            //Regex rule = new Regex(@"^\w*{0,3}$");

            for (int i=0;i<=words.Length;i++)
            {
                if (words[i].Length <= n) Console.WriteLine(words[i]);
            }
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
            else Console.WriteLine("Неверный пароль!");

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
