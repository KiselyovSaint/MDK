using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDK
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSpecSym("sdsd..!12345"));
        }
        public static int CountSpecSym(string text)
        {
            int countSym = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsLetterOrDigit(text[i]) && text[i] != ' ')
                    countSym++;
            }
            return countSym;
        }
    }
}
