using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int startingPosition = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split().ToArray();
            int damage = 1;
            while (commands[0] != "Supernova")
            {
                int steps = int.Parse(commands[1]);
                string direction = commands[0];

               
                if (direction == "left")
                {
                    for (int k = 0; k < steps; k++)
                    {
                        if (startingPosition <= 0)
                        {
                            startingPosition = plane.Length;
                            damage++;
                        }
                        startingPosition--;
                        plane[startingPosition] -= damage;
                    }                        
                }
                if (direction == "right")
                {
                    for (int l = 0; l < steps; l++)
                    {
                        if (startingPosition >= plane.Length - 1)
                        {
                            startingPosition = -1;
                            damage++;
                        }
                        startingPosition++;
                        plane[startingPosition] -= damage;
                    }
                }
                
                commands = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
