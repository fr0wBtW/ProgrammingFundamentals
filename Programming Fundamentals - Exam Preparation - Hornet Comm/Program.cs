using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals___Exam_Preparation___Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string[] line = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
            while (line[0] != "Hornet is Green")
            {
                if (line.Length != 2)
                {
                    line = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                string leftPart = line[0];
                string rightPart = line[1];

                if (leftPart.All(char.IsDigit) && rightPart.All(char.IsLetterOrDigit))
                {
                    string reversed = new string(leftPart.ToCharArray().Reverse().ToArray());

                    messages.Add($"{reversed} -> {rightPart}");
                }
                else if (leftPart.All(c => !char.IsDigit(c)) &&
                    rightPart.All(char.IsLetterOrDigit))
                {
                    string reverseCase = ReverseCase(rightPart);

                    broadcasts.Add($"{reverseCase} -> {leftPart}");
                }
                line = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Count == 0 ? "None" :
                string.Join(Environment.NewLine, broadcasts));
            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Count == 0 ? "None" :
                string.Join(Environment.NewLine, messages));
        }

        private static string ReverseCase(string rightPart)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rightPart.Length; i++)
            {
                if (char.IsUpper(rightPart[i]))
                {
                    result.Append(char.ToLower(rightPart[i]));
                }
                else if (char.IsLower(rightPart[i]))
                {
                    result.Append(char.ToUpper(rightPart[i]));
                }
                else
                {
                    result.Append(rightPart[i]);
                }
            }
            return result.ToString();
        }
    }
}
