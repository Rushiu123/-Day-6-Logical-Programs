using System.Diagnostics;

namespace Day_6_Logical_Programs
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            Console.WriteLine("1). Fibonacci series  2). Perfect Number  3). Prime Number  4). Reverse a Number  5). Coupon Numbers 6).Stop Watch");
            Console.WriteLine("7. Vending Machine.\n8. Day Of Week \n9.Tep Conversion \n10.Monthly Payment \n11.Square Root \n12.To Binary.\n13. Swap Nibble\n");
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
                case 6:
                    StopWatchCls.GetStopWatch();
                    break;
                //Q7. Vending Machine
                case 7:
                    VendingMachine.VendingMachineFn();
                    break;
                case 8:
                    DayOfWeek.Day of WeekFn();
                    break;
                case 9:
                    TemperatureConversion.GetTempConvert();
                    break;

                 case 10:
                    MonthlyPayment.GetMonthlyPayment();
                    break;

                case 11:
                    SquareRoot.GetSquareRoot();
                    break;
                case 12:
                    ToBinary.GetBinary();
                    break;
                case 13:
                    SwapNibble.GetSwapNibble();
                    break;
            }
                      


            int time = (int)stopWatch.ElapsedMilliseconds;

            System.Console.WriteLine($"Elaspsed time is {time}");
        }
    }
}