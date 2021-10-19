using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ').ToList();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (!wordsCount.ContainsKey(words[i]))
                {
                    wordsCount.Add(words[i], 0);
                }
                wordsCount[words[i]]++;
            }

            List<string> word = new List<string>();

            foreach (var print in wordsCount)
            {
                if (print.Value % 2 != 0)
                {
                    word.Add(print.Key);
                }
            }
            Console.Write(string.Join(", ", word));
            Console.WriteLine();
        }
    }
}
