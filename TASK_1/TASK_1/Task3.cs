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
            uint testNum = 1668;
            Assert.AreEqual(21, DigitalRoot(testNum));
        }
        [Test]
        public static void Test2()
        {
            uint testNum = 1;
            Assert.AreEqual(1, DigitalRoot(testNum));
        }
        public static uint DigitalRoot(uint num)
        {
            uint intPartOfNumber = num / 10;
            uint sum = 0;
            if (intPartOfNumber == 0)
            {
                sum += num;
            }
            else
            {
                uint i = 1;
                while (intPartOfNumber >= 10)
                {
                    intPartOfNumber /= 10;
                    i++;
                }
                sum += intPartOfNumber + DigitalRoot(num % (uint)Convert.ToInt32(Math.Pow(10, i)));
            }
            return sum;
        }
    }
}
