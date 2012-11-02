using System;
using System.Collections.Generic;

namespace Helpers.TraceOutput
{
    public static class Trace
    {

        private static ITraceOutputStrategy _outputStrategy;

        static Trace()
        {
            _outputStrategy = null;
        }

        public static void Output(string text)
        {
            _outputStrategy.OutputTrace(new TraceData(text,0));
        }
    }
}
