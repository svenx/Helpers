namespace Helpers.TraceOutput
{
    public class FormatTrace
    {

        public FormatTrace NextFormatting { get; set; }

        public FormatTrace()
        {
            NextFormatting = null;
        }

        public string Format(TraceData traceData)
        {
            string s;
            s = traceData.Level + traceData.Text + NextFormatting.Format(traceData);
            return s;
        }
    }
}
