using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal sum = 0M;

            for (int i = 0; i < n; i++)
            {
                decimal[] input = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
                decimal raindropsCount = input[0];
                decimal squareMeters = input[1];
                decimal regionalCoefficient = raindropsCount / squareMeters;

                sum += regionalCoefficient;

            }

            if (density != 0)
            {
                Console.WriteLine($"{sum/density:f3}");
            }
            else
            {
                Console.WriteLine($"{sum:f3}");
            }
        }
    }
}
