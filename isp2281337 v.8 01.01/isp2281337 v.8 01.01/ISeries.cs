using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isp2281337_v._8_01._01
{
    interface ISeries
    {
        double Next { get; }
        double GetNext();
        void Reset();
        void SetStart(int startValue);
    }
}
