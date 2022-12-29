using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    internal class Square_Root
    {
        public static void GetSquareRoot()
        {
            double epsilon = 1e-15, t, sqRt;
            Console.WriteLine("Enter a number :");
            int c = Convert.ToInt32(Console.ReadLine());
            t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2;
            }
            sqRt = Math.Round(t, 2);
            Console.WriteLine(sqRt);

        }
    }
}
