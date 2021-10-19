using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            var leftpart = numbers.Take(k).Reverse().ToArray();
            var rightpart = numbers.Reverse().Take(k).ToArray();
            leftpart = leftpart.Concat(rightpart).ToArray();
            var midElements = numbers.Skip(k).Take(k * 2).ToArray();

            Console.WriteLine(string.Join(" ", midElements.Select((el, i) => el += leftpart[i])));
        }
    }
}
