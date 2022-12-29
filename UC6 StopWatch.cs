using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    class UC6_StopWatch
    {
        public static void stopWatch()
        {
            Stopwatch watch = new Stopwatch();
            Console.Write("Stopwatch started ... Perform a task.");
            watch.Start();

            //Perform a task
            int num1, num2, temp;
            Console.WriteLine("\nSwap the numbers : \n\nEnter two numbers :");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping : {0} & {1}", num1, num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping : {0} & {1}", num1, num2);

            //Watch Stopping after compliting the task
            watch.Stop();
            Console.WriteLine("Elapsed time to execute the program : " + watch.Elapsed.ToString());
        }
    }
    
}

