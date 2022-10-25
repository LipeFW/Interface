namespace Interface.GALS
{
    public class LexicalError : AnalysisError
    {
        public LexicalError(string msg, int position, int line) : base(msg, position, line) { }

        public LexicalError(string msg) : base(msg) { }
    }
}
