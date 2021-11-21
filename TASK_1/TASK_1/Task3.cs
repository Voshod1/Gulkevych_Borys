using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TASK_1
{
    [TestFixture]
    class Task3
    {
        [Test]
        public static void Test1()
        {
            uint testNum = 493193;
            Assert.AreEqual(2, DigitalRoot(testNum));
        }
        [Test]
        public static void Test2()
        {
            uint testNum = 1;
            Assert.AreEqual(1, DigitalRoot(testNum));
        }
        public static uint DigitalRoot(uint num)
        {
            uint sum = (uint)num.ToString().ToCharArray().Sum(digit => digit - '0');
            if (sum>9)
            {
                sum = DigitalRoot(sum);
            }
            return sum;
        }
    }
}


