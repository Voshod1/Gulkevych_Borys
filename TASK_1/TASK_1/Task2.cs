using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    [TestFixture]
    class Task2
    {
        [Test]
        public static void Test1()
        {
            string testLine = "Mokkoo";
            Assert.AreEqual("M", first_non_repeating_letter(testLine));
        }
        [Test]
        public static void Test2()
        {
            string testLine = "sTreSS";
            Assert.AreEqual("T", first_non_repeating_letter(testLine));
        }
        public static string first_non_repeating_letter(string line)
        {
            var result = line.GroupBy(c => c.ToString(), c => c, StringComparer.OrdinalIgnoreCase).Where(g => g.Count() == 1).Select(g => g.Key).First();
            return result;
        }
    }
}
