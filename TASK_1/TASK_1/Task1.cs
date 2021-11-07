using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TASK_1
{
    [TestFixture]
    class Task1
    {
        [Test]
        public static void Test1()
        {
            List<object> listForTest = GetIntegersFromList(new List<object>() { 1, 2, 'a', 'b' });
            Assert.AreEqual(new List<object>() { 1, 2 }, listForTest);
        }
        [Test]
        public static void Test2()
        {
            List<object> listForTest = GetIntegersFromList(new List<object>() { 1, 2, 'a', 'b', 0, 15 });
            Assert.AreEqual(new List<object>() { 1, 2, 0, 15 }, listForTest);
        }
        public static List<object> GetIntegersFromList(List<object> listOfElements)
        {
            List<object> listOfDigits = new List<object> { };
            listOfDigits = listOfElements.Where(element => element.GetType() == 0.GetType()).ToList();
            return listOfDigits;
        }

    }
}
