using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //fuel 25l per 1 mile = 1.6 km
            // havy wing needs 1.5*25l per 1.6km
            //tatal fuel 1.5*25l+5%
            
            decimal distanceInMiles = decimal.Parse(Console.ReadLine());
            decimal tankCapacity = decimal.Parse(Console.ReadLine());
            decimal milesInHavyWings = decimal.Parse(Console.ReadLine());

            decimal milesInNonHavyWings = distanceInMiles - milesInHavyWings;
            decimal fuelInNonHavyWings = milesInNonHavyWings * 25M;
            decimal fuelInHavyWings = milesInHavyWings * (25M * 1.5M);

            decimal fuelConsumption = fuelInHavyWings + fuelInNonHavyWings;
            decimal tolerance = fuelConsumption * 5 / 100;

            decimal totalFuelConsumption = fuelConsumption + tolerance;
            if (tankCapacity < totalFuelConsumption)
            {
                decimal fuelNotEnough = totalFuelConsumption - tankCapacity;
                Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
                Console.WriteLine($"We need {fuelNotEnough:f2}L more fuel.");
            }
            else
            {
                decimal fuelLeft = tankCapacity - totalFuelConsumption;
                Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
                Console.WriteLine($"Enough with {fuelLeft:f2}L to spare!");
            }

        }
    }
}
