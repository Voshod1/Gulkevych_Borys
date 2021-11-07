using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TASK_1
{
    [TestFixture]
    class Task5
    {
        public string name { get; set; }
        public string surname { get; set; }
        [Test]
        public static void Test1()
        {
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            Assert.AreEqual("(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)", GuestSorter(s));
        }
        [Test]
        public static void Test2()
        {
            string s = "Jake:Johnson;Alan:Johnson;David:Mure;Bill:Johnson";
            Assert.AreEqual("(Johnson, Alan)(Johnson, Bill)(Johnson, Jake)(Mure, David)".ToUpper(), GuestSorter(s));
        }
        public static string GuestSorter(string str)
        {
            var guests = new List<Task5> { };
            str = str.ToUpper();
            string[] helpingString = str.Split(";");
            foreach (string p in helpingString)
            {
                string[] nameSurname = p.Split(":");
                guests.Add(new Task5 { surname = nameSurname[1], name = nameSurname[0] });
            }
            var guestsSorted = guests.OrderBy(x => x.name).OrderBy(x => x.surname);
            string guestsResult = "";
            foreach (Task5 guest in guestsSorted)
            {
                guestsResult = guestsResult + "(" + guest.surname + ", " + guest.name + ")";
            }
            return guestsResult;
        }
    }
}
