namespace Interface.GALS
{
    public class AnalysisError : Exception
    {
        public int Position { get; set; }

        public AnalysisError(string msg, int position) : base(msg)
        {
            Position = position;
        }

        public AnalysisError(string msg) : base(msg)
        {
            Position = -1;
        }

        public string toString()
        {
            return base.ToString() + ", @ " + Position;
        }
    }
}
