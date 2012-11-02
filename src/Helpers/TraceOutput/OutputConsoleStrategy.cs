using System;

namespace Helpers.TraceOutput
{
    public class OutputConsoleStrategy:ITraceOutputStrategy
    {
        public void OutputTrace(TraceData traceData)
        {
            Console.WriteLine();
        }
    }
}
