using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TASK_1
{
    [TestFixture]
    class Task4
    {
        [Test]
        public static void Test1()
        {
            int[] testArr = { 1, 3, 6, 2, 2, 0, 4, 5 };
            int testNum = 5;
            Assert.AreEqual(4, CountPairs(testArr, testNum));
        }
        [Test]
        public static void Test2()
        {
            int[] testArr = { 1, 3, 6, 2, 2, 0, 4, 5 };
            int testNum = 1;
            Assert.AreEqual(1, CountPairs(testArr, testNum));
        }
        public static int CountPairs(int[] arr, int number)
        {
            int count = 0;
            foreach (int digitOne in arr)
            {
                foreach (int digitTwo in arr)
                {
                    if ((digitOne != digitTwo) & ((digitOne + digitTwo) == number))
                    {
                        count++;
                    }
                }
                arr = arr.Where((item, index) => index != 0).ToArray();
            }
            return count;
        }
    }
}
