using System;

namespace Interface.GALS
{
    public class Semantico : Constants
    {
        public string Operador { get; set; }
        public string Codigo { get; set; }
        public Stack<string> PilhaTipos { get; set; }
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

            Console.WriteLine($"#{action}" + (token != null ? $" (token: {token?.Lexeme})" : ""));

            // lançando exceção se o arquivo n estiver salvo, verificar
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
                Codigo += $"\ncall tipoid[mscorlib]System.{tipoClasse}::Parse(string)";
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
                Codigo += $"\n.locals({TipoVar} {identificador}";
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
            else if (token.Lexeme == "real")
            {
                TipoVar = "float64";
            }
        }

        private void ActionVinteOito()
        {
            // esquema de tradução completo.pdf última página (AVA)
        }

        private void ActionVinteSete()
        {
            // esquema de tradução completo.pdf última página (AVA)
        }

        private void ActionVinteSeis()
        {
            // esquema de tradução completo.pdf última página (AVA)
        }

        private void ActionVinteCinco()
        {
            // esquema de tradução completo.pdf última página (AVA)
        }

        private void ActionVinteQuatro()
        {
            // esquema de tradução completo.pdf última página (AVA)
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
            if (tipo1 == "int" && tipo2 == "int")
            {
                PilhaTipos.Push("int");
            }
            else
            {
                //exibir na caixa de mensagens com linha
                throw new SemanticError("tipos incompatíveis em expressão aritmética.", line: Line);
            }
            Codigo += "\nor";
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
                //exibir na caixa de mensagens com linha
                throw new SemanticError("tipos incompatíveis em expressão lógica.", line: Line);
            }
            Codigo += "\nand";
        }

        // feito (?)
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
            Codigo += ".assembly extern mscorlib { }\r\n.assembly _codigo_objeto{ }\r\n.module _codigo_objeto.exe\r\n\r\n.class public _UNICA{ \r\n.method static public void _principal()\r\n{\r\n.entrypoint";
        }

        // feito
        private void ActionQuatorze()
        {
            var tipo = PilhaTipos.Pop();
            if (tipo == "int")
                Codigo += "\nconv.i8";

            if (tipo == "char")
                Codigo += "\ncall void [mscorlib]System.Console::Write(string)";
            else if (tipo == "string")
                Codigo += "\ncall void [mscorlib]System.Console::Write(string)";
            else if (tipo == "bool")
                Codigo += "\ncall void [mscorlib]System.Console::Write(bool)";
            else if (tipo == "int")
                Codigo += "\ncall void [mscorlib]System.Console::Write(int64)";
            else if (tipo == "float")
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
                case (">"):
                    Codigo += "\ncgt";
                    break;
                case ("<"):
                    Codigo += "\nclt";
                    break;
                case ("=="):
                    Codigo += "\nceq";
                    break;
                case ("!="):
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
            if (tipo == "float")
            {
                PilhaTipos.Push("float");
            }
            else if (tipo == "int")
            {
                PilhaTipos.Push("int");
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
            if (tipo == "float")
            {
                PilhaTipos.Push("float");
            }
            else if (tipo == "int")
            {
                PilhaTipos.Push("int");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }
        }

        // CONFERIR COM A JOYCE
        private void ActionSeis(Token token)
        {
            PilhaTipos.Push("float");

            token.Lexeme = token.Lexeme.Replace(".", "0,");

            if (token.Lexeme.Contains("d"))
            {
                var arraystr = token.Lexeme.Split("d");
                var numeroDpsDoD = double.Parse(arraystr[1]);
                // lançando exceção pq o número pode ser mt grande
                // por exemplo .3d128 => tem que elevar 10^128, ai gera exceção pq é mt grande
                var result = (decimal)Math.Pow(10, numeroDpsDoD);
                var aaaa = decimal.Parse(arraystr[0]) * result;
                var resultadoFinal = decimal.Parse(aaaa + arraystr[1].Substring(arraystr[1].IndexOf("d") + 2));

                Codigo += "\nldc.r8 " + resultadoFinal;
            }
            else
                Codigo += "\nldc.r8 " + token.Lexeme;

            Line = token.Line;
        }

        // CONFERIDO
        private void ActionCinco(Token token)
        {
            PilhaTipos.Push("int");

            if (token.Lexeme.Contains("d"))
            {
                var arraystr = token.Lexeme.Split("d");
                var numeroDpsDoD = int.Parse(arraystr[1]);
                var result = Math.Pow(10, numeroDpsDoD);
                var resultadoFinal = (int.Parse(arraystr[0]) * result).ToString() + arraystr[1].Substring(arraystr[1].IndexOf("d") + 2);

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
            if (tipo1 == "float" && (tipo2 == "float"))
            {
                PilhaTipos.Push("float");
            }
            else if (tipo1 == "int" && (tipo2 == "int"))
            {
                PilhaTipos.Push("int");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }

            Codigo += "div";
        }

        // feito
        private void ActionTres()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();

            if (tipo1 == "float" && (tipo2 == "float"))
            {
                PilhaTipos.Push("float");
            }
            else if (tipo1 == "int" && (tipo2 == "int"))
            {
                PilhaTipos.Push("int");
            }
            else if (tipo1 == "int" && (tipo2 == "float"))
            {
                PilhaTipos.Push("float");
            }
            else if (tipo1 == "float" && (tipo2 == "int"))
            {
                PilhaTipos.Push("float");
            }
            else
            {
                //exibir na caixa de mensagens
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética", line: Line);
            }

            Codigo += "mul";
        }

        // feito
        private void ActionDois()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();
            if (tipo1 == "float" && (tipo2 == "float"))
            {
                PilhaTipos.Push("float");
            }
            else if (tipo1 == "int" && (tipo2 == "int"))
            {
                PilhaTipos.Push("int");
            }
            else if (tipo1 == "int" && (tipo2 == "float"))
            {
                PilhaTipos.Push("float");
            }
            else if (tipo1 == "float" && (tipo2 == "int"))
            {
                PilhaTipos.Push("float");
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

            if (tipo1 == "float" && (tipo2 == "float"))
            {
                PilhaTipos.Push("float");
            }
            else if (tipo1 == "int" && (tipo2 == "int"))
            {
                PilhaTipos.Push("int");
            }
            else if (tipo1 == "int" && (tipo2 == "float"))
            {
                PilhaTipos.Push("float");
            }
            else if (tipo1 == "float" && (tipo2 == "int"))
            {
                PilhaTipos.Push("float");
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
