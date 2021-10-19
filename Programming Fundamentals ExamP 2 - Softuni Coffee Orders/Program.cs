using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals_ExamP_2___Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal capsulePrice = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                uint capsulesCount = uint.Parse(Console.ReadLine());
                int resultDaysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal finalResult = (resultDaysInMonth * capsulesCount) * capsulePrice;

                Console.WriteLine($"The price for the coffee is: ${finalResult:f2}");

                totalPrice += finalResult;
            }
            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
