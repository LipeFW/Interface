namespace Interface.GALS
{
    public class AnalysisError : Exception
    {
        public int Position { get; set; }
        public int Line { get; set; }


        public AnalysisError(string msg, int position, int line = 0) : base(msg)
        {
            Position = position;
            Line = line;
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
