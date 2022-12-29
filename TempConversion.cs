using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    internal class TempConversion
    {
        public static void GetTempConvert()
        {
            // Celsius to Fahrenheit
            Console.WriteLine("Enter a temprature in Celsius  : ");
            float valInCelsius = Convert.ToInt32(Console.ReadLine());
            float celToFahren = ((valInCelsius * 9 / 5) + 32);
            Console.WriteLine("temp in fahrenheit :" + celToFahren);
            // Fahrenheit to Celsius
            Console.WriteLine("Enter a temprature in Fahrenheit : ");
            float valInFahren = Convert.ToSingle(Console.ReadLine());
            float fahToCelsius = (valInFahren - 32) * (5 / (float)9);
            Console.WriteLine("temp in Celsius :" + fahToCelsius);

        }
    }
}
