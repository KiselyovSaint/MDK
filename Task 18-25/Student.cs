using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        private string LName;
        private string FName;
        private string Patronymic;
        private int Age;

        public Student(string LName, string FName, string Patronymic, int Age)
        {
            this.LName = LName;
            this.FName = FName;
            this.Patronymic = Patronymic;
            this.Age = Age;
        }
        public string _LName
        {
            get { return LName; }
            set { LName = value; }
        }
        public string _FName
        {
            get { return FName; }
            set { FName = value; }
        }
        public string _Patronymic
        {
            get { return Patronymic; }
            set { Patronymic = value; }
        }
        public int _Age
        {
            get { return Age; }
            set { Age = value; }
        }

    }
}
