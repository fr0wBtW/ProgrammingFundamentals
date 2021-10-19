using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamental_ExamP_2___Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long dayCount = long.Parse(Console.ReadLine());
            long runner = long.Parse(Console.ReadLine());
            long averageLaps = long.Parse(Console.ReadLine());
            long lapLenght = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            long totalCapacity = trackCapacity * dayCount;
            if (runner > totalCapacity)
            {
                runner = totalCapacity;
            }

            long totalMeters = (runner * averageLaps * lapLenght);
            long totalKm = totalMeters / 1000;
            decimal moneyForMarathon = totalKm * moneyPerKm;
            Console.WriteLine("Money raised: {0:F2}", moneyForMarathon);
        }
    }
}
