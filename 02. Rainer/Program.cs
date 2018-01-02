using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int index = input.Last();
            input.RemoveAt(input.Count - 1);
            int counter = 0;
            List<int> result = new List<int>(input);
            bool isDeath = true;

            while (isDeath)
            {                
                for (int i = 0; i < result.Count; i++)
                {
                    result[i]--;
                                    
                }
                if (result.ElementAt(index) == 0)
                {
                    isDeath = false;
                    break;
                }
                else
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        if (result[i] == 0)
                        {
                            result[i] = input[i];
                        }
                    }                    
                }
                index = int.Parse(Console.ReadLine());                
                counter++;
            }

            Console.WriteLine(String.Join(" ", result));
            Console.WriteLine(counter);
        }
    }
}
