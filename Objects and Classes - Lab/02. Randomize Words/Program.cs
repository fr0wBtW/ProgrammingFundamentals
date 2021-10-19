using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var words1 = rnd.Next(0, words.Length);
                var a = words[words1];
                var b = words[i];

                words[words1] = b;
                words[i] = a;
            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
