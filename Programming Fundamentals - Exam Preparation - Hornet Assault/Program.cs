using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals___Exam_Preparation___Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count <= 0)
                {
                    break;

                }
                if (beehives[i] < hornets.Sum())
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else
                {
                    beehives[i] = beehives[i] - hornets.Sum();
                    hornets.RemoveAt(0);
                }
            }
            if (beehives.Where(b => b > 0).ToList().Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
