using System;
using System.Collections.Generic;

namespace TASK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DZ knowledge of C# \n Exercise 1:");
            var task1Result = Task1.GetIntegersFromList(listOfElements: new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231});
            Console.WriteLine("1, 2, a, b, aasf, 1, 123, 231");
            foreach(var element in task1Result)
            {
                Console.Write(element+", ");
            }
            Console.WriteLine("\n Exercise 2:");
            var task2Result = Task2.first_non_repeating_letter(line: "stress");
            Console.WriteLine("stress first non repeating => " + task2Result);
            task2Result = Task2.first_non_repeating_letter(line: "dDiGItS");
            Console.WriteLine("dDiGItS first non repeating => " + task2Result);
            Console.WriteLine("\n Exercise 3:");
            var task3Result = Task3.DigitalRoot(num: 4213);
            Console.WriteLine("Digital root for 4213 is " + task3Result);
            Console.WriteLine("\n Exercise 4:");
            var task4Result = Task4.CountPairs(arr: new int[] { 1, 3, 5, 2, 6, 0 }, number: 6);
            Console.WriteLine("From { 1, 3, 5, 2, 6, 0 } we can create 6 from " + task4Result + " pairs");
            Console.WriteLine("\n Exercise 5:");
            string s = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            var task5Result = Task5.GuestSorter(str: s);
            Console.WriteLine("Unsorted guests: " + s + "\nSorted guests: "+task5Result);
            Console.WriteLine("\n Additional Exercise 1:");
            int numberResult = AdditionalTask1.FindBigCombination(3049);
            Console.WriteLine("3049 => " + numberResult);
            numberResult = AdditionalTask1.FindBigCombination(321);
            Console.WriteLine("321 => " + numberResult);
        }
    }
}
