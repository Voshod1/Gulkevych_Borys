using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TASK_1
{
    [TestFixture]
    class AdditionalTask1
    {
        [Test]
        public static void TestWrongCase()
        {
            int testNumber = -111;
            Assert.AreEqual(-1, FindBigCombination(num: testNumber));
        }
        [Test]
        public static void TestStandartCase()
        {
            int testNumber = 2017;
            Assert.AreEqual(2071, FindBigCombination(num: testNumber));
        }
        public static int FindBigCombination(int num)
        {
            char[] numString = num.ToString().ToCharArray();
            var numLen = numString.Length;
            int i;
            for (i = numLen - 1; i > 0; i--)
            {
                if (numString[i] > numString[i - 1])
                {
                    break;
                }
            }
            if ((i == 0)||(num<0))
            {
                return -1;
            }
            else
            {
                int x = numString[i - 1], min = i;
                for(int j=i+1; j < numLen; j++)
                {
                    if (numString[j] > x && numString[j] < numString[min])
                    {
                        min = j;
                    }
                }
                char temp = numString[i - 1];
                numString[i - 1] = numString[min];
                numString[min] = temp;
                
            }
            string resultDigit = "";
            foreach(char ch in numString)
            {
                resultDigit += ch;
            }
            return Convert.ToInt32(resultDigit);
        }
    }
}
