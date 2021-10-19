using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            input.Sort();

            var result = input.Where(i => i.Length < 5).Distinct();
            List<string> result1 = new List<string>(result);

            result1.Sort();
            result1 = result1.ConvertAll(x => x.ToLower());


            Console.WriteLine(string.Join(", ", result1.Distinct()));
        }
    }
}
