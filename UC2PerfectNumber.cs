using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    internal class UC2PerfectNumber
    {
        public static void perfectNumber()
        {
            Console.Write("Enter Number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine(n + " is a perfect number");
            }
            else
            {
                Console.WriteLine(n + "is not a perfect number");
            }
        }
    }
}
