using Interface.GALS.Constantes;

namespace Interface.GALS.Semantic
{
    public class Semantico : Constants
    {
        public string Operador { get; set; }
        public string Codigo { get; set; }
        public Stack<string> PilhaTipos { get; set; }
        public Stack<string> PilhaRotulos { get; set; }
        public int NumeroRotulo { get; set; }
        public int Line { get; set; }
        public string TipoVar { get; set; }
        public List<string> ListaIdentificadores { get; set; } // ??????????
        public Dictionary<string, string> TabelaSimbolos { get; set; }
        // CRIAR TABELA DE SÍMBOLOS
        // CRIAR UM MAPA EM C# -> Map<string,string> onde o primeiro string é identificador e o segundo string é o tipo

        // tabela de símbolos, usada para armazenar os identificadores e respecitivos tipos, conforme
        // declaração de variáveis

        public Semantico()
        {
            PilhaTipos = new Stack<string>();
            Operador = "";
            Codigo = "";
            TipoVar = "";
            ListaIdentificadores = new List<string>();
            TabelaSimbolos = new Dictionary<string, string>();
            PilhaRotulos = new Stack<string>();
        }

        public void executeAction(int action, Token token)
        {
            switch (action)
            {
                default:
                    break;

                case 1:
                    ActionUm();
                    break;

                case 2:
                    ActionDois();
                    break;

                case 3:
                    ActionTres();
                    break;

                case 4:
                    ActionQuatro();
                    break;

                case 5:
                    ActionCinco(token);
                    break;

                case 6:
                    ActionSeis(token);
                    break;

                case 7:
                    ActionSete();
                    break;

                case 8:
                    ActionOito();
                    break;

                case 9:
                    ActionNove(token);
                    break;

                case 10:
                    ActionDez();
                    break;

                case 11:
                    ActionOnze();
                    break;

                case 12:
                    ActionDoze();
                    break;

                case 13:
                    ActionTreze();
                    break;

                case 14:
                    ActionQuatorze();
                    break;

                case 15:
                    ActionQuinze();
                    break;

                case 16:
                    ActionDezesseis();
                    break;

                case 17:
                    ActionDezessete();
                    break;

                case 18:
                    ActionDezoito();
                    break;

                case 19:
                    ActionDezenove();
                    break;

                case 20:
                    ActionVinte();
                    break;

                case 21:
                    ActionVinteUm(token);
                    break;

                case 22:
                    ActionVinteDois(token);
                    break;

                case 24:
                    ActionVinteQuatro();
                    break;

                case 25:
                    ActionVinteCinco();
                    break;

                case 26:
                    ActionVinteSeis();
                    break;

                case 27:
                    ActionVinteSete();
                    break;

                case 28:
                    ActionVinteOito();
                    break;

                case 30:
                    ActionTrinta(token);
                    break;

                case 31:
                    ActionTrintaUm();
                    break;

                case 32:
                    ActionTrintaDois(token);
                    break;

                case 33:
                    ActionTrintaTres(token);
                    break;

                case 34:
                    ActionTrintaQuatro();
                    break;

                case 35:
                    ActionTrintaCinco();
                    break;
            }

            // Console.WriteLine($"#{action}" + (token != null ? $" (token: {token?.Lexeme})" : ""));

            try
            {
                File.WriteAllText($"{Interface.saveDirectory.Split(".txt")[0]}.il", Codigo);
            }
            catch
            {
            }
        }

        //feito -- testar
        private void ActionTrintaCinco()
        {
            foreach (var identificador in ListaIdentificadores)
            {
                if (!TabelaSimbolos.TryGetValue(identificador, out var t))
                    throw new SemanticError("");

                var tipoId = TabelaSimbolos[identificador];

                var tipoClasse = "";

                switch (tipoId)
                {
                    case "int64":
                        tipoClasse = "Int64";
                        break;
                    case "float64":
                        tipoClasse = "Double";
                        break;
                    default:
                        break;
                }

                Codigo += "\ncall string[mscorlib]System.Console::ReadLine()";
                Codigo += $"\ncall {tipoId}[mscorlib]System.{tipoClasse}::Parse(string)";
                Codigo += $"\nstloc {identificador}";
            }

            ListaIdentificadores.Clear();
        }

        //feito -- testar
        private void ActionTrintaQuatro()
        {
            var id = ListaIdentificadores[ListaIdentificadores.Count - 1];
            ListaIdentificadores.RemoveAt(ListaIdentificadores.Count - 1);

            if (!TabelaSimbolos.TryGetValue(id, out var t))
                throw new SemanticError("");

            var tipoId = TabelaSimbolos[id];

            var tipoExpressao = PilhaTipos.Pop();

            if (tipoId != tipoExpressao)
                throw new SemanticError("");

            if (tipoId == "int64")
                Codigo += "\nconv.i8";

            Codigo += $"\nstloc {id}";
        }

        //feito -- testar
        private void ActionTrintaTres(Token token)
        {
            var id = token.Lexeme;

            if (!TabelaSimbolos.TryGetValue(id, out var t))
                throw new SemanticError("");

            var tipoId = TabelaSimbolos[id];

            PilhaTipos.Push(tipoId);

            Codigo += $"\nldloc {id}";

            if (tipoId == "int64")
                Codigo += "\nconv.r8";
        }

        //feito
        private void ActionTrintaDois(Token token)
        {
            ListaIdentificadores.Add(token.Lexeme);
        }

        // feito -- testar
        private void ActionTrintaUm()
        {
            foreach (var identificador in ListaIdentificadores)
            {
                if (TabelaSimbolos.TryGetValue(identificador, out var ret))
                    throw new SemanticError("");

                TabelaSimbolos.Add(identificador, TipoVar);
                Codigo += $"\n.locals({TipoVar} {identificador})";
            }

            ListaIdentificadores.Clear();
        }

        // feito ?
        private void ActionTrinta(Token token)
        {
            if (token.Lexeme == "int")
            {
                TipoVar = "int64";
            }
            else if (token.Lexeme == "float")
            {
                TipoVar = "float64";
            }
        }

        private void ActionVinteOito()
        {
            Codigo += "\nbrtrue " + PilhaRotulos.Pop();
        }

        private void ActionVinteSete()
        {
            NumeroRotulo++;
            Codigo += "novo_rotulo" + NumeroRotulo + ":";
            PilhaRotulos.Push("novo_rotulo" + NumeroRotulo);
        }

        private void ActionVinteSeis()
        {
            Codigo += "\n" + PilhaRotulos.Pop() + ":";
        }

        private void ActionVinteCinco()
        {
            NumeroRotulo++;
            Codigo += "\nbr novo_rotulo" + NumeroRotulo;
            Codigo += "\n" + PilhaRotulos.Pop() + ":";
            PilhaRotulos.Push("novo_rotulo" + NumeroRotulo);
        }

        private void ActionVinteQuatro()
        {
            NumeroRotulo++;
            Codigo += "\nbrfalse novo_rotulo" + NumeroRotulo + "\n";
            PilhaRotulos.Push("novo_rotulo" + NumeroRotulo);
        }


        // feito ?
        private void ActionVinteDois(Token token)
        {
            PilhaTipos.Push("string");
            Codigo += "\nldstr " + token.Lexeme;

            Line = token.Line;
        }

        // feito ?
        private void ActionVinteUm(Token token)
        {
            // constantes do tipo char da linguagem fonte (\n, \s, \t) equivalem a constantes
            // do tipo string em IL ("\n", " ", "\t", respectivamente)
            PilhaTipos.Push("char");

            if (token.Lexeme == "\n")
            {
                Codigo += "\nldstr \"\n\"";
                Line++;
            }
            else if (token.Lexeme == "\\s")
                Codigo += "\nldstr \" \" ";
            else if (token.Lexeme == "\t")
                Codigo += "\nldstr \"\\t\"";
            else
                Codigo += "\nldstr " + token.Lexeme;

            Line = token.Line;
        }

        // feito
        private void ActionVinte()
        {
            // ambos os tipos devem ser inteiros para divisão inteira
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();
            if (tipo1 == "int64" && tipo2 == "int64")
            {
                PilhaTipos.Push("int64");
            }
            else
            {
                //exibir na caixa de mensagens com linha
                throw new SemanticError("tipos incompatíveis em expressão aritmética.", line: Line);
            }

            Codigo += "\nconv.i8";
            Codigo += "\nstloc divisor_fixed";
            Codigo += "\nconv.i8";
            Codigo += "\nstloc dividend_fixed";
            Codigo += "\nldloc dividend_fixed";
            Codigo += "\nconv.r8";
            Codigo += "\nldloc dividend_fixed";
            Codigo += "\nconv.r8";
            Codigo += "\nldloc divisor_fixed";
            Codigo += "\nconv.r8";
            Codigo += "\ndiv";
            Codigo += "\nconv.i8";
            Codigo += "\nconv.r8";
            Codigo += "\nldloc divisor_fixed";
            Codigo += "\nconv.r8";
            Codigo += "\nmul";
            Codigo += "\nsub";
        }

        // feito
        private void ActionDezenove()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();
            if (tipo1 == "bool" && tipo2 == "bool")
            {
                PilhaTipos.Push("bool");
            }
            else
            {
                //exibir na caixa de mensagens com linha
                throw new SemanticError("tipos incompatíveis em expressão lógica.", line: Line);
            }
            Codigo += "\nor";
        }


        // feito
        private void ActionDezoito()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();
            if (tipo1 == "bool" && tipo2 == "bool")
            {
                PilhaTipos.Push("bool");
            }
            else
            {
                throw new SemanticError("tipo(s) incompatível(is) em expressão lógica.", line: Line);
            }
            Codigo += "\nand";
        }

        // feito (?) -- verificar
        private void ActionDezessete()
        {
            // println -> imprimir nova linha 
            // ldstr "\n"
            Codigo += "\nldstr \"\\n\"";
            Codigo += "\ncall void [mscorlib]System.Console::Write(string)";
        }

        // feito
        private void ActionDezesseis()
        {
            Codigo += "\r\nret\r\n}\r\n}\r\n";
        }

        // feito
        private void ActionQuinze()
        {
            Codigo += ".assembly extern mscorlib { }" +
                "\r\n.assembly _codigo_objeto{ }" +
                "\r\n.module _codigo_objeto.exe" +
                "\r\n\r\n.class public _UNICA{ " +
                "\r\n.method static public void _principal()" +
                "\r\n{" +
                "\r\n.entrypoint" +
                "\r\n.locals (int64 divisor_fixed)" +
                "\r\n.locals (int64 dividend_fixed)";
        }

        // feito
        private void ActionQuatorze()
        {
            var tipo = PilhaTipos.Pop();
            if (tipo == "int64")
                Codigo += "\nconv.i8";

            if (tipo == "char")
                Codigo += "\ncall void [mscorlib]System.Console::Write(string)";
            else if (tipo == "string")
                Codigo += "\ncall void [mscorlib]System.Console::Write(string)";
            else if (tipo == "bool")
                Codigo += "\ncall void [mscorlib]System.Console::Write(bool)";
            else if (tipo == "int64")
                Codigo += "\ncall void [mscorlib]System.Console::Write(int64)";
            else if (tipo == "float64")
                Codigo += "\ncall void [mscorlib]System.Console::Write(float64)";
        }

        // feito
        private void ActionTreze()
        {
            var tipo = PilhaTipos.Pop();
            if (tipo == "bool")
                PilhaTipos.Push("bool");
            else
                throw new SemanticError("tipo incompatível em expressão lógica.", line: Line);
            Codigo += "\nldc.i4.1";
            Codigo += "\nxor";
        }

        // feito
        private void ActionDoze()
        {
            PilhaTipos.Push("bool");
            Codigo += "ldc.i4.0";
        }

        // feito
        private void ActionOnze()
        {
            PilhaTipos.Push("bool");
            Codigo += "\nldc.i4.1";
        }


        // pegar o trabalho de tcc q foi mencionado no "3o aula - semantico.pdf"
        // página 50 tem um exemplo de !=
        // feito -- MAS TEM Q TESTAR
        private void ActionDez()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();

            if (tipo1 == tipo2)
                PilhaTipos.Push("bool");
            else
                throw new SemanticError("tipos incompatíveis em expressão relacional", line: Line);

            switch (Operador)
            {
                case ">":
                    Codigo += "\ncgt";
                    break;
                case "<":
                    Codigo += "\nclt";
                    break;
                case "==":
                    Codigo += "\nceq";
                    break;
                case "!=":
                    Codigo += "\nceq";
                    Codigo += "\nldc.i4 0";
                    Codigo += "\nceq";
                    break;
                default: break;
            }
        }

        // feito
        private void ActionNove(Token token)
        {
            Operador = token.Lexeme;

            Line = token.Line;
        }

        // feito
        private void ActionOito()
        {
            var tipo = PilhaTipos.Pop();
            if (tipo == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo == "int64")
            {
                PilhaTipos.Push("int64");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }
            Codigo += "\nldc.i8 -1";
            Codigo += "\nconv.r8";
            Codigo += "\nmul";
        }

        // feito
        private void ActionSete()
        {
            var tipo = PilhaTipos.Pop();
            if (tipo == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo == "int64")
            {
                PilhaTipos.Push("int64");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }
        }

        // CONFERIR COM A JOYCE - conferir!!
        private void ActionSeis(Token token)
        {
            PilhaTipos.Push("float64");

            token.Lexeme = token.Lexeme.Replace(".", "0.");

            if (token.Lexeme.Contains("d"))
            {
                var arrayStr = token.Lexeme.Split("d");
                var numeroDpsDoD = double.Parse(arrayStr[1]);
                var resultPotenciacao = (decimal)Math.Pow(10, numeroDpsDoD);
                var resultMultiplicacao = decimal.Parse(arrayStr[0].Replace(".", ",")) * resultPotenciacao;
                var resultadoFinal = decimal.Parse(resultMultiplicacao + arrayStr[1].Substring(arrayStr[1].IndexOf("d") + 2));

                Codigo += "\nldc.r8 " + resultadoFinal;
            }
            else
                Codigo += "\nldc.r8 " + token.Lexeme;

            Line = token.Line;
        }

        // CONFERIDO -- mas conferir de novo
        private void ActionCinco(Token token)
        {
            PilhaTipos.Push("int64");

            if (token.Lexeme.Contains("d"))
            {
                var arrayStr = token.Lexeme.Split("d");
                var numeroDpsDoD = int.Parse(arrayStr[1]);
                var result = Math.Pow(10, numeroDpsDoD);
                var resultadoFinal = (int.Parse(arrayStr[0]) * result).ToString() + arrayStr[1].Substring(arrayStr[1].IndexOf("d") + 2);

                Codigo += "\nldc.i8 " + resultadoFinal;
            }
            else
                Codigo += "\nldc.i8 " + token.Lexeme;

            Codigo += "\nconv.r8";
            Line = token.Line;
        }

        // feito
        private void ActionQuatro()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();

            // na divisão os operandos devem ser do mesmo tipo
            if (tipo1 == "float64" && tipo2 == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo1 == "int64" && tipo2 == "int64")
            {
                PilhaTipos.Push("int64");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }

            Codigo += "\ndiv";
        }

        // feito
        private void ActionTres()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();

            if (tipo1 == "float64" && tipo2 == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo1 == "int64" && tipo2 == "int64")
            {
                PilhaTipos.Push("int64");
            }
            else if (tipo1 == "int64" && tipo2 == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo1 == "float64" && tipo2 == "int64")
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }

            Codigo += "\nmul";
        }

        // feito
        private void ActionDois()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();
            if (tipo1 == "float64" && tipo2 == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo1 == "int64" && tipo2 == "int64")
            {
                PilhaTipos.Push("int64");
            }
            else if (tipo1 == "int64" && tipo2 == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo1 == "float64" && tipo2 == "int64")
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }

            Codigo += "\nsub";
        }

        // feito
        private void ActionUm()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();

            if (tipo1 == "float64" && tipo2 == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo1 == "int64" && tipo2 == "int64")
            {
                PilhaTipos.Push("int64");
            }
            else if (tipo1 == "int64" && tipo2 == "float64")
            {
                PilhaTipos.Push("float64");
            }
            else if (tipo1 == "float64" && tipo2 == "int64")
            {
                PilhaTipos.Push("float64");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }

            Codigo += "\nadd";
        }
    }
}
