using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Authorization
    {
        public string login;
        public string password;

        internal bool CheckAuthorization()
        {
            const string login = "User";
            const string pass = "12345";

            if ((this.login != login) || (this.password != pass))
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
    }
}
