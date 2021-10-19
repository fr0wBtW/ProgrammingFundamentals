using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionaryResources = new Dictionary<string, int>();
            int counter = 0;

            while (true)
            {
                counter++;
                var recource = Console.ReadLine();
                recource.Split();

                if (recource == "stop")
                {
                    break;
                }

                int count = int.Parse(Console.ReadLine());

                if (!dictionaryResources.ContainsKey(recource))
                {
                    dictionaryResources.Add(recource, 0);
                }
                dictionaryResources[recource] += count;
            }
            foreach (var item in dictionaryResources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
