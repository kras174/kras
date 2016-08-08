using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Authorization
    {
        string login;
        string password;

        internal void startAuthorization(int Method)
        {
            int numberOfTries = 3;
            switch (Method)
            {
                case 1:
                    do
                    {
                        if (numberOfTries != 3) Console.WriteLine("Осталось попыток: " + numberOfTries);

                        Console.WriteLine("Введите логин:");
                        login = Console.ReadLine();

                        Console.WriteLine("Введите пароль:");
                        password = Console.ReadLine();

                        numberOfTries--;
                    }
                    while (!CheckAuthorization() && numberOfTries != 0);
                    break;
                case 2:
                    do
                    {
                        if (numberOfTries != 3) Console.WriteLine("Осталось попыток: " + numberOfTries);

                        Console.WriteLine("Введите логин:");
                        login = Console.ReadLine();

                        Console.WriteLine("Введите пароль:");
                        password = Console.ReadLine();

                        numberOfTries--;
                    }
                    while (!CheckAuthorizationFile() && numberOfTries != 0);
                    break;
            }

            do
            {
                if (numberOfTries != 3) Console.WriteLine("Осталось попыток: " + numberOfTries);

                Console.WriteLine("Введите логин:");
                login = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();

                numberOfTries--;
            }
            //while (!CheckAuthorization() && numberOfTries != 0);
            while (!CheckAuthorizationFile() && numberOfTries != 0);
        }

        //----Авторизация пользователя из программы (Домашнее задание А)
        private bool CheckAuthorization()
        {
            const string login = "User";
            const string password = "12345";

            if ((this.login != login) || (this.password != password))
            {
                Console.WriteLine("Неверный логин или пароль!");
                return false;
            }
            else
            {
                Console.WriteLine("Вход выполнен!");
                return true;
            }
        }

        //----Авторизация пользователя из файла (Домашнее задание А*)
        internal bool CheckAuthorizationFile()
        {
            bool result = false;
            try
            {
                StreamReader lg = new StreamReader("logins.txt");
                StreamReader ps = new StreamReader("pass.txt");

                string lineLogin, linePass;
                while (((lineLogin = lg.ReadLine()) != null) && ((linePass = ps.ReadLine()) != null))
                {
                    if ((this.login != lineLogin) || (this.password != linePass))
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                        break;
                    }
                 }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            if (result) Console.WriteLine("Вход выполнен!");
            else Console.WriteLine("Неверный логин или пароль!");
            return result;
        }
    }
}
