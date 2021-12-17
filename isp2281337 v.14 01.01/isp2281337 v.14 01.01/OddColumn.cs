﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp2281337_v._14_01._01
{
    internal class OddColumn
    {
        public int GetColumn(int[,] matrix)
        {
            bool isColumnOdd;
            int columnIndex = -1;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                isColumnOdd = true;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] % 2 == 0)
                    {
                        isColumnOdd = false;
                        break;
                    }
                }
                if (isColumnOdd == true)
                {
                    columnIndex = i + 1;
                    return columnIndex;
                }
            }
            return 0;
        }
    }
}
