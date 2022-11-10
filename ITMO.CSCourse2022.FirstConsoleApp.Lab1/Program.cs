using System;

namespace ITMO.CSCourse2022.FirstConsoleApp.Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname;
            Console.WriteLine("Пожалуйста введите имя \a ");
            myname = Console.ReadLine();
            Console.WriteLine("Здравствуйте, {0}", myname);
        }
    }
}
