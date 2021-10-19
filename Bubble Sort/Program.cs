using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 6, 7, 8, 9, 0, 10, 15, 1, 2, 3, 4, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int temp = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
