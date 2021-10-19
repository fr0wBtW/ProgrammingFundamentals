using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals_ExamP_2___Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> idAndName = new Dictionary<int, string>();
            Dictionary<string, List<string>> allData = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine()
                   .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                input.RemoveAll(x => x == "");
                if (input[0] == "Time")
                {
                    break;
                }

                var id = int.Parse(input[0]);
                var eventName = input[1];
                var participants = new List<string>();

                if (eventName[0] == '#')
                {
                    eventName = eventName.Remove(0, 1);
                    for (int i = 2; i < input.Count; i++)
                    {
                        if (input[i][0] == '@')
                        {
                            participants.Add(input[i]);
                        }
                    }

                    if (idAndName.ContainsKey(id) && idAndName[id] != eventName)
                    {
                        continue;
                    }

                    if (!idAndName.ContainsKey(id))
                    {
                        idAndName[id] = eventName;

                        if (!allData.ContainsKey(eventName))
                        {
                            allData[eventName] = new List<string>();
                        }

                        foreach (var participant in participants)
                        {
                            if (!allData[eventName].Contains(participant))
                            {
                                allData[eventName].Add(participant);
                            }
                        }
                    }
                }
                if (idAndName.ContainsKey(id) && allData.ContainsKey(eventName))
                {
                    foreach (var participant in participants)
                    {
                        if (!allData[eventName].Contains(participant))
                        {
                            allData[eventName].Add(participant);
                        }
                    }
                }
            }
            allData = allData.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in allData)
            {
                var participants = item.Value;
                participants.Sort();
                Console.WriteLine($"{item.Key} - {participants.Count}");
                for (int i = 0; i < participants.Count; i++)
                {
                    Console.WriteLine($"{participants[i]}");
                }
            }
        }
    }
}
