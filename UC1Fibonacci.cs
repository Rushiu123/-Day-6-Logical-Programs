using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    internal class UC1Fibonacci
    {
        public static void fibonacci()
        {
            Console.WriteLine("Enter the Number :");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            arr[0] = 0;
            arr[1] = 1;

            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}

