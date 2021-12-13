﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp2281337_v._12_01._01
{
    internal class TwoDigitNumber
    {
        public int NumbersProduct(int x)
        {
            int tempNumber = x;
            x = (tempNumber / 10) * (tempNumber % 10);
            if (x != 0)
                return x;
            else throw new ArgumentNullException();
        }

        public int NumbersSum(int x)
        {
            int tempNumber = x;
            x = (tempNumber / 10) + (tempNumber % 10);
            if (x != 0)
                return x;
            else throw new ArgumentNullException();
        }
    }
}
