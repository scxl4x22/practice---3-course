using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp2281337_v._10_01._01
{
    internal class NegPosInArray
    {
        public (int posCount, int negCount) GetNegPosCount(ArrayList numArray)
        {
            int[] array = new int[numArray.Count];
            numArray.CopyTo(array);
            int negativeCount = 0, positiveCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    negativeCount++;
                if (array[i] > 0)
                    positiveCount++;
            }
            return (positiveCount, negativeCount);
        }
    }
}