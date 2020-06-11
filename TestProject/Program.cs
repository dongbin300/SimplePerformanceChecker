using SimplePerformanceChecker;
using System;
using System.Collections.Generic;

namespace TestProject
{
    class Program
    {
        private static List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        static void Main(string[] args)
        {
            PerformanceChecker checker = new PerformanceChecker(Method1, Method2);
            checker.CountOfPerform = 1_000_000;

            var elapsedTimes = checker.Perform();
            foreach (double elapsedTime in elapsedTimes)
            {
                Console.WriteLine(elapsedTime);
            }
            // 1.160833
            // 1.874759

            Console.WriteLine(checker.PerformResult());
            // ================================
            // Method1 : 1.160833sec
            // Method2 : 1.874759sec
            // ================================
        }

        /// <summary>
        /// Foreach Method
        /// </summary>
        static void Method1()
        {
            int fifteen;

            foreach (int number in numbers)
            {
                if (number.Equals(15))
                {
                    fifteen = number;
                    break;
                }
            }
        }

        /// <summary>
        /// Linq Method
        /// </summary>
        static void Method2()
        {
            int fifteen;

            fifteen = numbers.Find(num => num.Equals(15));
        }
    }
}
