using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals___Exam_Preparation___Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wings = int.Parse(Console.ReadLine());
            double distance1000Wings = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2} m.", (wings / 1000) * distance1000Wings);
            var secondFlaps = wings / 100;
            var result = secondFlaps + ((wings / endurance) * 5);
            Console.WriteLine("{0} s.", result);
        }
    }
}
