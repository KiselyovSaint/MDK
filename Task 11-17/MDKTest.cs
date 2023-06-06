using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MDK;

namespace MDKTest
{
    [TestClass]
    public class MDKTest
    {

        // Тест функции сложения двух чисел.
        [TestMethod]
        public void SumTwoNumTesta10b5resTest15()
        {
            int a = 10;
            int b = 5;
            int resTest = 15;

            int res = Program.SumTwoNum(a, b);

            Assert.AreEqual(resTest, res);
        }

        // Тест функции которая ищет наибольшее число в массиве.
        [TestMethod]
        public void MaxNumberarr4_2_9_7resTest9()
        {
            int[] arr = { 4, 2, 9, 7 };
            int resTest = 9;

            int res = Program.MaxNumber(arr);

            Assert.AreEqual(resTest, res);
        }

        // Тест функции умножения двух чисел.
        [TestMethod]
        public void MultiplicationTwoNuma10b5resTest50()
        {
            int a = 10;
            int b = 5;
            int resTest = 50;

            int res = Program.MultiplicationTwoNum(a, b);

            Assert.AreEqual(resTest, res);
        }

        // Тест функции нахождения максимального числа из трёх чисел.
        [TestMethod]
        public void MaxThreeNuma10b5c6resTest10()
        {
            int a = 10;
            int b = 5;
            int c = 6;
            int resTest = 10;

            int res = Program.MaxThreeNum(a, b, c);

            Assert.AreEqual(resTest, res);
        }

        // Тест функции для определения кол-ва букв в строке.
        [TestMethod]
        public void CountLettertextkak12345kakresTest6()
        {
            string text = "kak12345kak";
            int resTest = 6;

            int res = Program.CountLetter(text);

            Assert.AreEqual(resTest, res);
        }

        // Тест функции для определения кол-ва цифр в строке.
        [TestMethod]
        public void CountNumbertextkak12345kakresTest6()
        {
            string text = "kak12345kak";
            int resTest = 5;

            int res = Program.CountNum(text);

            Assert.AreEqual(resTest, res);
        }

        // Тест функции для определения кол-ва спец. символов в строке.
        [TestMethod]
        public void CountSpecSymrtextkak12345kakresTest6()
        {
            string text = "kak12345kak..!!";
            int resTest = 4;

            int res = Program.CountSpecSym(text);

            Assert.AreEqual(resTest, res);
        }
    }
}
