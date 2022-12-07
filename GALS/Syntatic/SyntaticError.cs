namespace Interface.GALS.Syntatic
{
    public class SyntaticError : AnalysisError
    {
        public SyntaticError(string msg, int position, int line = 0) : base(msg, position, line) { }

        public SyntaticError(string msg) : base(msg) { }
    }
}
