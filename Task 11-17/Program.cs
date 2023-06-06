using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MDK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSpecSym("kakdela123.8!!"));
        }

        // Функция сложения двух чисел.
        public static int SumTwoNum(int a, int b)
        {
            return a + b;
        }

        // Функция, которая ищет наибольшее число в массиве.
        public static int MaxNumber(int[] arr)
        {
            int maxNum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxNum)
                {
                    maxNum = arr[i];
                }
            }
            return maxNum;
        }

        // Функция умножения двух чисел.
        public static int MultiplicationTwoNum(int a, int b)
        {
            return a * b;
        }

        //Функция нахождения максимального числа из трёх чисел.
        public static int MaxThreeNum(int a, int b, int c)
        {
            int maxNum = Math.Max(a, Math.Max(b, c));
            return maxNum;
        }

        // Функция для определения кол-ва букв в строке.
        public static int CountLetter(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    count++;
                }
            }
            return count;
        }

        // Функция для определения кол-ва цифр в строке.
        public static int CountNum(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsNumber(text[i]))
                {
                    count++;
                }
            }
            return count;
        }

        // Функция для определения кол-ва спец. символов в строке.
        public static int CountSpecSym(string text)
        {
            int countSym = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsLetterOrDigit(text[i]) && text[i] != ' ')
                    countSym++;
            }
            return countSym;
        }
    }
}
