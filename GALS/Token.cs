namespace Interface.GALS
{
    public class Token
    {
        public int Id { get; }
        public string Lexeme { get; }
        public int Position { get; }
        public int Line { get; }

        public Token(int id, string lexeme, int position, int line)
        {
            Id = id;
            Lexeme = lexeme;
            Position = position;
            Line = line;
        }

        public string toString()
        {
            return Id + " ( " + Lexeme + " ) @ " + Position;
        }
    }
}
