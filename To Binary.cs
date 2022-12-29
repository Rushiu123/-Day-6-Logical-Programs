using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    internal class To_Binary
    {
        public static int[] binary = new int[8];
        public static void GetBinary()
        {
            Console.WriteLine("Enter a Decimal Number : ");
            int decNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; decNum > 0; i++)
            {
                binary[i] = decNum % 2;
                decNum /= 2;
                Console.Write(binary[i] + " ");
            }
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                Console.Write("\n" + binary[i] + " ");
                Console.Write(binary[i] + " ");
            }
        }
    }
}
