using AdventOfCode2024.Day1;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2024.Cmmon
{
    public static class RouteClass
    {
        public static void Route(int day)
        {
            switch (day)
            {
                case 1:
                    Puzzle1.GetDistances();
                    break;

                default:
                    Console.WriteLine("Please enter valid day.");
                    break;
            }
        }
    }
}
