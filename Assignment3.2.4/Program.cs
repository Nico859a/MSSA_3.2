using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 numbers for your total and avg calculation: ");
            Console.WriteLine();
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the forth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
                      
            double total;
            double avg;

            CalcTotalAndAvg(out total, out avg, num1, num2, num3, num4);
            Console.WriteLine($"The total is {total}");
            Console.WriteLine($"The avg is {avg}");
         
        }

        static void CalcTotalAndAvg(out double total, out double avg, params double[] nums)
        {
            total = 0;

            foreach (double number in nums)
            {
                total += number;
            }
            avg = nums.Length > 0 ? total / nums.Length : 0;
        }
    }
}
