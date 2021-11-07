using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TASK_1
{
    [TestFixture]
    class AdditionalTask2
    {
        [Test]
        public static void StandartCheck()
        {
            uint testNumber = 2149583361;
            Assert.AreEqual("128.32.10.1", ReturnAdress(intIP: testNumber));
        }
        [Test]
        public static void ZeroCheck()
        {
            uint testNumber = 0;
            Assert.AreEqual("0.0.0.0", ReturnAdress(intIP: testNumber));
        }
        public static string ReturnAdress(uint intIP)
        {
            uint part1 = intIP / 16777216;
            uint restOFNumber = intIP - (part1 * 16777216);
            uint part2 = restOFNumber / 65536;
            restOFNumber = restOFNumber - (part2 * 65536);
            uint part3 = restOFNumber / 256;
            uint part4 = restOFNumber - (part3 * 256);
            string resultIP = part1+"."+part2+"."+part3+"."+part4;
            return resultIP;
        }
    }
}
