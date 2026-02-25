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
    }
}