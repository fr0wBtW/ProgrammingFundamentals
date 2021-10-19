using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailsAndNames = new Dictionary<string, string>();

            while (true)
            {
                string names = Console.ReadLine();

                if (names == "stop")
                {
                    break;
                }

                string emails = Console.ReadLine();


                if (!emailsAndNames.ContainsKey(names))
                {
                    emailsAndNames.Add(names, "");
                }
                emailsAndNames[names] += emails;
            }

            foreach (var people in emailsAndNames)
            {
                if (!people.Value.EndsWith("uk") && !people.Value.EndsWith("us"))
                {
                    Console.WriteLine("{0} -> {1}", people.Key, people.Value);
                }

            }
        }
    }
}
