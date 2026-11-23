using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQFluent
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //ex 4

            // String[] lines = File.ReadAllLines("test.txt");

            // int mediumLine = lines.Count(line => line.Length > 30);

            // double charMedia = lines.Average(line => line.Length);

            // bool bigLine = lines.Any(line => line.Length > 120);

            // IEnumerable<string> hasCapitalY = lines.Where(line => line.Contains('Y')).Select(liner => liner.Split()[0].ToUpper());

            // Console.WriteLine(mediumLine);
            // Console.WriteLine(charMedia);
            // Console.WriteLine(bigLine);

            // foreach(string l in hasCapitalY)
            // {
            //     Console.WriteLine(l);
            // }

            // ================================================================

            //ex 5

            String[] lines = File.ReadAllLines("test.txt");

            int mediumLine = (from line in lines where line.Length > 30 select line).Count();

            double charMedia = (from line in lines select line.Length).Average();

            bool bigLine = (from line in lines where line.Length > 120 select line).Any();

            IEnumerable<string> hasCapitalY = from line in lines where line.Contains('Y') select line.Split()[0].ToUpper();

            Console.WriteLine(mediumLine);
            Console.WriteLine(charMedia);
            Console.WriteLine(bigLine);

            foreach(string l in hasCapitalY)
            {
                Console.WriteLine(l);
            }
        }
    }
}
