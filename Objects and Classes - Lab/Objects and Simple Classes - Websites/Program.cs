using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_and_Simple_Classes___Websites
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> commands = new List<Website>();
            string input = Console.ReadLine();


            while (input != "end")
            {
                string[] input1 = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                string host = input1[0];
                string domain = input1[1];
                List<string> queries;
                if (input1.Length > 2)
                {
                    queries = input1[2].Split(',').ToList();
                }
                else
                {
                    queries = new List<string>();
                }

                commands.Add(new Website(host, domain, queries));

                input = Console.ReadLine();
            }
            foreach (var item in commands)
            {
                Console.Write("https://www.{0}.{1}", item.Host, item.Domain);

                if (item.Queries.Count > 0)
                {
                    Console.Write("/query?=[{0}]", string.Join("]&[", item.Queries));
                }
                Console.WriteLine();
            }
        }
        class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Queries { get; set; }



            public Website(string host, string domain, List<string> queries)
            {
                this.Host = host;
                this.Domain = domain;
                this.Queries = queries;
            }
        }
    }
}
