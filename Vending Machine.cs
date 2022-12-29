using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    internal class Vending_Machine
    {
        public static int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
        public static int quotient = 0;
        public static int notesCount = 0;
        public static void VendingMachineFn()
        {
            Console.WriteLine("Enter the amount to be returned by the Vending Machine :");
            int amount = Convert.ToInt32(Console.ReadLine()); //Example : 480 Rupees

            for (int i = 0; i < notes.Length; i++)
            {
                //Ex: if 480 >= notes[i=2]
                if (amount >= notes[i])
                {
                    quotient = amount / notes[i]; // 480/100 = 4 Quotient
                    amount = amount - (quotient * notes[i]); // 480 - (4*100) = left Amount now = 80
                    Console.WriteLine("{0}*{1}:{2}", notes[i], quotient, notes[i] * quotient); //100*4 = 400
                    notesCount = notesCount + quotient; //notecount=4, Amount is now 80 Rupees
                }
            }
            Console.WriteLine("Minimum number of notes : " + notesCount);
        }
    }
}
