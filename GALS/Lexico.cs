namespace Interface.GALS
{
    public class Lexico : Constants
    {
        private int Position { get; set; }
        private string Input;
        private int line { get; set; } = 1;
        private bool isNextLine = false;

        public Lexico()
        {
            new Lexico("");
        }

        public Lexico(string input)
        {
            Input = input;
        }

        public void setInput(string input)
        {
            Input = input;
            Position = 0;
        }

        public string getInput()
        {
            return Input;
        }

        public Token nextToken()
        {
            if (!hasInput())
                return null;

            int start = Position;
            int state = 0;
            int lastState = 0;
            int endState = -1;
            int end = -1;

            while (hasInput())
            {
                if (isNextLine)
                { 
                    line++;
                    isNextLine = false;
                }

                lastState = state;

                if (validateChar() == '\n')
                {
                    isNextLine = true;
                    Position++;
                    break;
                }

                state = nextState(nextChar(), state);

                if (state < 0)
                    break;

                else
                {
                    if (tokenForState(state) >= 0)
                    {
                        endState = state;
                        end = Position;
                    }
                }
            }
            if (endState < 0 || (endState != state && tokenForState(lastState) == -2))
                throw new LexicalError(SCANNER_ERROR[lastState], start);

            if(!isNextLine)
                Position = end;

            int token = tokenForState(endState);

            if (token == 0)
                return nextToken();
            else
            {
                var lenght = end - start;
                string lexeme = Input.Substring(start, lenght);
                token = lookupToken(token, lexeme);
                return new Token(token, lexeme, start, line);
            }
        }

        private int nextState(char c, int state)
        {
            int start = SCANNER_TABLE_INDEXES[state];
            int end = SCANNER_TABLE_INDEXES[state + 1] - 1;

            while (start <= end)
            {
                int half = (start + end) / 2;

                if (SCANNER_TABLE[half, 0] == c)
                    return SCANNER_TABLE[half, 1];
                else if (SCANNER_TABLE[half, 0] < c)
                    start = half + 1;
                else  //(SCANNER_TABLE[half][0] > c)
                    end = half - 1;
            }

            return -1;
        }

        private int tokenForState(int state)
        {
            if (state < 0 || state >= TOKEN_STATE.Length)
                return -1;

            return TOKEN_STATE[state];
        }

        public int lookupToken(int aux, string key)
        {
            int start = SPECIAL_CASES_INDEXES[aux];
            int end = SPECIAL_CASES_INDEXES[aux + 1] - 1;

            while (start <= end)
            {
                int half = (start + end) / 2;
                int comp = SPECIAL_CASES_KEYS[half].CompareTo(key);

                if (comp == 0)
                    return SPECIAL_CASES_VALUES[half];
                else if (comp < 0)
                    start = half + 1;
                else  //(comp > 0)
                    end = half - 1;
            }

            return aux;
        }

        private bool hasInput()
        {
            return Position < Input.Length;
        }

        private char nextChar()
        {
            if (hasInput())
                return Input[Position++];
            else
            {
                var aux = -1;
                return (char)aux;
            }
        }

        private char validateChar()
        {
            if (hasInput())
                return Input[Position];
            else
            {
                var aux = -1;
                return (char)aux;
            }
        }
    }

}
