using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                string read = Console.ReadLine();

                if (read == "END")
                {
                    break;
                }
                string[] tokens = read.Split();
                string command = tokens[0];

                switch (command)
                {
                    case "A":
                        string name = tokens[1];
                        string phone = tokens[2];

                        if (phonebook.ContainsKey(name))
                        {
                            phonebook[name] = phone;
                        }
                        else
                        {
                            phonebook.Add(name, phone);
                        }
                        break;
                    case "S":
                        string searchName = tokens[1];
                        if (phonebook.ContainsKey(searchName))
                        {
                            string foundNumber = phonebook[searchName];
                            Console.WriteLine("{0} -> {1}", searchName, foundNumber);
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", searchName);
                        }
                        break;


                }
            }
        }
    }
}
