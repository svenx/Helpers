using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helpers.TraceOutput
{
    interface ITraceOutputStrategy
    {
        void OutputTrace(TraceData traceData);
    }
}
