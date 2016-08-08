using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Authorization
    {
        string login;
        string password;

        internal void startAuthorization()
        {
            int numberOfTries = 3;
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
            //while (!CheckAuthorizationFile() && numberOfTries != 0) ;
        }

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

        //internal bool CheckAuthorizationFile()
        //{
            
        //}
    }
}
