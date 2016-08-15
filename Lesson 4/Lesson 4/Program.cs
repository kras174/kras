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

            Employer worker1 = new Employer();
            Employer worker2 = new Employer();
            Employer worker3 = new Employer();

            Employer.ShowInfo();

            Console.ReadKey();
        }
    }
}
