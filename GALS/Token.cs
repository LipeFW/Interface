namespace Interface.GALS
{
    public class Token
    {
        public int Id { get; }
        public string Lexeme { get; }
        public int Position { get; }

        public Token(int id, string lexeme, int position)
        {
            Id = id;
            Lexeme = lexeme;
            Position = position;
        }

        public string toString()
        {
            return Id + " ( " + Lexeme + " ) @ " + Position;
        }
    }
}
