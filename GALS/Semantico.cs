namespace Interface.GALS
{
    public class Semantico : Constants
    {
        public string Operador { get; set; }
        public string Codigo { get; set; }
        public Stack<Type> PilhaTipos { get; set; }
        public int Line { get; set; }

        public Semantico()
        {
            PilhaTipos = new Stack<Type>();
            Operador = "";
            Codigo = "";
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
            }

            Console.WriteLine($"#{action}" + (token != null ? $" (token: {token?.Lexeme})" : ""));

            File.WriteAllText($"{Interface.saveDirectory}.txt", Codigo);
        }

        // feito ?
        private void ActionVinteDois(Token token)
        {
            PilhaTipos.Push(typeof(string));
            Codigo += "\nldstr " + token.Lexeme;

            Line = token.Line;
        }

        // feito ?
        private void ActionVinteUm(Token token)
        {
            // constantes do tipo char da linguagem fonte (\n, \s, \t) equivalem a constantes
            // do tipo string em IL ("\n", " ", "\t", respectivamente)
            PilhaTipos.Push(typeof(char));

            if (token.Lexeme == "\n")
            {
                Codigo += "ldstr \"\n\"";
                Line++;
            }
            else if (token.Lexeme == "\\s")
                Codigo += "ldstr \" \" ";
            else if (token.Lexeme == "\t")
                Codigo += "ldstr \"\\t\"";
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
            if (tipo1 == typeof(int) && tipo2 == typeof(int))
            {
                PilhaTipos.Push(typeof(int));
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
            if (tipo1 == typeof(bool) && tipo2 == typeof(bool))
            {
                PilhaTipos.Push(typeof(bool));
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
            if (tipo1 == typeof(bool) && tipo2 == typeof(bool))
            {
                PilhaTipos.Push(typeof(bool));
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
            Codigo += "ldstr \"\n\"";
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
            if (tipo == typeof(int))
                Codigo += "\nconv.i8";

            if (tipo == typeof(char))
                Codigo += "\ncall void [mscorlib]System.Console::Write(string)";
            else if (tipo == typeof(string))
                Codigo += "\ncall void [mscorlib]System.Console::Write(string)";
            else if (tipo == typeof(bool))
                Codigo += "\ncall void [mscorlib]System.Console::Write(bool)";
            else if (tipo == typeof(int))
                Codigo += "\ncall void [mscorlib]System.Console::Write(int64)";
            else if (tipo == typeof(float))
                Codigo += "\ncall void [mscorlib]System.Console::Write(float64)";
        }

        // feito
        private void ActionTreze()
        {
            var tipo = PilhaTipos.Pop();
            if (tipo == typeof(bool))
                PilhaTipos.Push(typeof(bool));
            else
                throw new SemanticError("tipo incompatível em expressão lógica.", line: Line);
            Codigo += "ldc.i4.1";
            Codigo += "xor";
        }

        // feito
        private void ActionDoze()
        {
            PilhaTipos.Push(typeof(bool));
            Codigo += "ldc.i4.0";
        }

        // feito
        private void ActionOnze()
        {
            PilhaTipos.Push(typeof(bool));
            Codigo += "ldc.i4.1";
        }


        // pegar o trabalho de tcc q foi mencionado no "3o aula - semantico.pdf"
        // página 50 tem um exemplo de !=
        private void ActionDez()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();

            if (tipo1 == tipo2)
                PilhaTipos.Push(typeof(bool));
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
            if (tipo == typeof(float))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo == typeof(int))
            {
                PilhaTipos.Push(typeof(int));
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
            if (tipo == typeof(float))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo == typeof(int))
            {
                PilhaTipos.Push(typeof(int));
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
            PilhaTipos.Push(typeof(float));

            token.Lexeme = token.Lexeme.Replace(".", "0,");

            if (token.Lexeme.Contains("d"))
            {
                var arraystr = token.Lexeme.Split("d");
                var numeroDpsDoD = double.Parse(arraystr[1].Substring(0, 1));
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
            PilhaTipos.Push(typeof(int));

            if (token.Lexeme.Contains("d"))
            {
                var arraystr = token.Lexeme.Split("d");
                var numeroDpsDoD = int.Parse(arraystr[1].Substring(0, 1));
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
            if (tipo1 == typeof(float) && (tipo2 == typeof(float)))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo1 == typeof(int) && (tipo2 == typeof(int)))
            {
                PilhaTipos.Push(typeof(int));
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

            if (tipo1 == typeof(float) && (tipo2 == typeof(float)))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo1 == typeof(int) && (tipo2 == typeof(int)))
            {
                PilhaTipos.Push(typeof(int));
            }
            else if (tipo1 == typeof(int) && (tipo2 == typeof(float)))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo1 == typeof(float) && (tipo2 == typeof(int)))
            {
                PilhaTipos.Push(typeof(float));
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
            if (tipo1 == typeof(float) && (tipo2 == typeof(float)))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo1 == typeof(int) && (tipo2 == typeof(int)))
            {
                PilhaTipos.Push(typeof(int));
            }
            else if (tipo1 == typeof(int) && (tipo2 == typeof(float)))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo1 == typeof(float) && (tipo2 == typeof(int)))
            {
                PilhaTipos.Push(typeof(float));
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

            if (tipo1 == typeof(float) && (tipo2 == typeof(float)))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo1 == typeof(int) && (tipo2 == typeof(int)))
            {
                PilhaTipos.Push(typeof(int));
            }
            else if (tipo1 == typeof(int) && (tipo2 == typeof(float)))
            {
                PilhaTipos.Push(typeof(float));
            }
            else if (tipo1 == typeof(float) && (tipo2 == typeof(int)))
            {
                PilhaTipos.Push(typeof(float));
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
