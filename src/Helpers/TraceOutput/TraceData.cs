namespace Helpers.TraceOutput
{
    public class TraceData
    {

        public string Text { get; private set; }
        public int Level { get; private set; }
        
        public TraceData(string text, int level)
        {
            Text = text;
            Level = level;
        }

    }
}
