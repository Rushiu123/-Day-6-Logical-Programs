using System.Diagnostics;

namespace Day_6_Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            Console.WriteLine("1). Fibonacci series  2). Perfect Number  3). Prime Number  4). Reverse a Number  5). Coupon Numbers");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Fibonacci.fibonacci();
                    break;
                case 2:
                    PerfectNumber.perfectNumber();
                    break;
                case 3:
                    PrimeNumber.primeNumber();
                    break;
                case 4:
                    Reverse.reverse();
                    break;
                case 5:
                    CouponNumbers.couponNumbers();
                    break;
            }
                        stopWatch.Stop();

            int time = (int)stopWatch.ElapsedMilliseconds;

            System.Console.WriteLine($"Elaspsed time is {time}");
        }
    }
}