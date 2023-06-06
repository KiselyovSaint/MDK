using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Артём", "Киселёв", "Александрович", 18);
            Console.WriteLine("Студент: ");
            Console.WriteLine("Имя: " + student1._FName);
            Console.WriteLine("Фамилия: " + student1._LName);
            Console.WriteLine("Отчество: " + student1._Patronymic);
            Console.WriteLine("Возраст: " + student1._Age);
        }
    }
}
