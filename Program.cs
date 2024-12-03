using AdventOfCode2024.Cmmon;
using System;

namespace AdventOfCode2024
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Day");
            var day = Convert.ToInt32(Console.ReadLine());
            if (day > 0)
            {
                RouteClass.Route(day);
            }
        }
    }
}
