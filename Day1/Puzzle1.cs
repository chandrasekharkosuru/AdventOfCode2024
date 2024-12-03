using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2024.Day1
{
    public static class Puzzle1
    {
        public static void GetDistances()
        {
            Console.WriteLine("Enter first set of values, seperated by ','");
            var firstPiar = Console.ReadLine().Split(',').Where(x => !string.IsNullOrEmpty(x)).Select(y => Convert.ToInt64(y)).OrderBy(x => x).ToList();

            Console.WriteLine("Enter Second set of values, seperated by ','");
            var secondPiar = Console.ReadLine().Split(',').Where(x => !string.IsNullOrEmpty(x)).Select(y => Convert.ToInt64(y)).OrderBy(x => x).ToList();

            if (firstPiar.Count == secondPiar.Count)
            {
                int distanceValue = 0;
                int lastIteration = 0;
                foreach (var leftPair in firstPiar)
                {
                    for (int i = lastIteration; i <= secondPiar.Count; i++)
                    {
                        distanceValue += ((int)(secondPiar[i] - leftPair));
                        lastIteration = i;
                        break;
                    }
                }
            }
        }

    }
}
