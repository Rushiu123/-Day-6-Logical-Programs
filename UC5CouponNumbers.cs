﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Logical_Programs
{
    class UC5Reverse
    {
        public static void couponNumbers()
        {
            int distinct = 0, count = 0;
            Console.WriteLine("Enter a number of given distinct coupons:");
            int couponNo = Convert.ToInt32(Console.ReadLine());
            bool[] isCollected = new bool[couponNo];
            while (distinct < couponNo)
            {
                Random random = new Random();
                int newCoupon = (int)(random.NextDouble() * couponNo);
                count++;
                if (!isCollected[newCoupon])
                {
                    distinct++;
                    isCollected[newCoupon] = true;
                }
            }

            Console.WriteLine("Total random number needed to have all distinct coupons:" + count);

        }
    }
}
