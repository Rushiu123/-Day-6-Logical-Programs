using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    internal class UC4Reverse
    {
        public static void reverse()
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int rev = 0, num = n;

            while (n > 0)
            {
                rev = rev * 10 + n % 10;
                n /= 10;
            }

            System.Console.WriteLine($"Reverse of {num} is {rev} ");

        }

    }
}

