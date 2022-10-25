﻿namespace Interface.GALS
{
    public class SemanticError : AnalysisError
    {
        public SemanticError(string msg) : base(msg)
        {
        }

        public SemanticError(string msg, int position, int line = 0) : base(msg, position, line)
        {
        }
    }
}
