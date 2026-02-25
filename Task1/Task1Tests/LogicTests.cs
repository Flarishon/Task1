using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void oneRubleOneCent()
        {
            int number = 101;
            string result = Logic.WordForms(number);

            Assert.AreEqual("1 рубль, 1 копейка", result);
        }

        [TestMethod()]
        public void specialGenitiveFormsWithUnits()
        {
            int number1 = 202;
            string result1 = Logic.WordForms(number1);

            int number2 = 303;
            string result2 = Logic.WordForms(number2);

            int number3 = 404;
            string result3 = Logic.WordForms(number3);

            Assert.AreEqual("2 рубля, 2 копейки", result1);
            Assert.AreEqual("3 рубля, 3 копейки", result2);
            Assert.AreEqual("4 рубля, 4 копейки", result3);
        }

        [TestMethod()]
        public void specialGenitiveForms()
        {
            int number1 = 2121;
            string result1 = Logic.WordForms(number1);

            int number2 = 2222;
            string result2 = Logic.WordForms(number2);

            int number3 = 3333;
            string result3 = Logic.WordForms(number3);

            int number4 = 4444;
            string result4 = Logic.WordForms(number4);

            Assert.AreEqual("21 рубль, 21 копейка", result1);
            Assert.AreEqual("22 рубля, 22 копейки", result2);
            Assert.AreEqual("33 рубля, 33 копейки", result3);
            Assert.AreEqual("44 рубля, 44 копейки", result4);
        }
        [TestMethod()]
        public void commonGenitiveForms()
        {
            int number1 = 505;
            string result1 = Logic.WordForms(number1);

            int number2 = 4658;
            string result2 = Logic.WordForms(number2);

            Assert.AreEqual("5 рублей, 5 копеек", result1);
            Assert.AreEqual("46 рублей, 58 копеек", result2);
        }
        [TestMethod()]
        public void onlyRubles()
        {
            int number = 5300;
            string result = Logic.WordForms(number);

            Assert.AreEqual("53 рубля ровно", result);
        }
        [TestMethod()]
        public void onlyCents()
        {
            int number = 96;
            string result = Logic.WordForms(number);

            Assert.AreEqual("96 копеек", result);
        }
    }
}