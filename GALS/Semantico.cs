using System;
using System.Text;

namespace Interface.GALS
{
    public class Semantico : Constants
    {
        public string Operador { get; set; }
        public string Codigo { get; set; }
        public Stack<Type> PilhaTipos { get; set; }

        public Semantico()
        {
            PilhaTipos = new Stack<Type>();
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
                    ActionSeis();
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

            File.WriteAllText("C:\\Users\\felipe.weber\\Downloads\\seilalalalalal.txt", Codigo);

            Console.WriteLine($"#{action}" + (token != null ? $" (token: {token?.Lexeme})" : ""));
        }

        private void ActionDez()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();

            if (tipo1 == tipo2)
                PilhaTipos.Push(typeof(bool));
            else
                throw new SemanticError("Erro semântico");

            switch(Operador)
            {
                case (">"):
                    Codigo += "cgt";
                    break;
                case ("<"):
                    Codigo += "clt";
                    break;
                case ("=="):
                    Codigo += "ceq";
                    break;
                default: break;
            }
        }

        private void ActionOnze()
        {
            PilhaTipos.Push(typeof(bool));
            Codigo += "ldc.i4.1";
        }

        private void ActionDoze()
        {
            PilhaTipos.Push(typeof(bool));
            Codigo += "ldc.i4.0";
        }

        private void ActionTreze()
        {
            var tipo = PilhaTipos.Pop();
            if (tipo == typeof(bool))
                PilhaTipos.Push(typeof(bool));
            else
                throw new SemanticError("Erro semântico");
            Codigo += "ldc.i4.1";
            Codigo += "xor";
        }

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

        private void ActionQuinze()
        {
            Codigo += ".assembly extern mscorlib { }\r\n.assembly _codigo_objeto{ }\r\n.module _codigo_objeto.exe\r\n\r\n.class public _UNICA{ \r\n.method static public void _principal()\r\n{\r\n.entrypoint";
        }

        private void ActionDezesseis()
        {
            Codigo += "\r\nret\r\n}\r\n}\r\n";
        }

        private void ActionDezessete()
        {
            throw new NotImplementedException();
        }

        private void ActionDezoito()
        {
            throw new NotImplementedException();
        }

        private void ActionDezenove()
        {
            throw new NotImplementedException();
        }

        private void ActionVinte()
        {
            throw new NotImplementedException();
        }

        private void ActionVinteUm(Token token)
        {
            PilhaTipos.Push(typeof(char));
            Codigo += "\nldstr " + token.Lexeme;
        }

        private void ActionVinteDois(Token token)
        {
            PilhaTipos.Push(typeof(string));
            Codigo += "\nldstr " + token.Lexeme;
        }

        private void ActionNove(Token token)
        {
            Operador = token.Lexeme;
        }

        private void ActionOito()
        {
            var cod = @"tipo:= pilha_tipos.desempilha
  se (tipo=float64) ou (tipo=int64) 
  então pilha_tipos.empilha (tipo) 
  senão erro semântico, parar
  fimse
  código.adiciona (ldc.i8 -1)
  código.adiciona (conv.r8)
  código.adiciona (mul)
";
        }

        private void ActionSete()
        {
            var cod = @"tipo:= pilha_tipos.desempilha
                      se (tipo=float64) ou (tipo=int64) 
                      então pilha_tipos.empilha (tipo) 
                      senão erro semântico, parar
                      fimse
                    ";
        }

        private void ActionSeis()
        {
            var cod = @"pilha_tipos.empilha (float64)
                          código.adiciona (ldc.r8 token.getLexeme)
                        ";
        }

        private void ActionCinco(Token token)
        {
            PilhaTipos.Push(typeof(int));
            Codigo += "\nldc.i8 "+ token.Lexeme;
            Codigo += "\nconv.r8";
        }

        private void ActionQuatro()
        {
            var cod = @"tipo1:= pilha_tipos.desempilha
              tipo2:= pilha_tipos.desempilha
              se (tipo1=tipo2) 
              então pilha_tipos.empilha (tipo1) 
              senão erro semântico, parar
              fimse
              código.adiciona (div)
            ";
        }

        private void ActionTres()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();
            if (tipo1 == typeof(float) || tipo2 == typeof(float))
            {
                PilhaTipos.Push(typeof(float));
            }
            else
            {
                PilhaTipos.Push(typeof(int));
            }

            Codigo += "mul";
        }

        private void ActionDois()
        {
            var tipo1 = PilhaTipos.Pop();
            var tipo2 = PilhaTipos.Pop();
            if (tipo1 == typeof(float) || tipo2 == typeof(float))
            {
                PilhaTipos.Push(typeof(float));
            }
            else
            {
                PilhaTipos.Push(typeof(int));
            }

            Codigo += "sub";
        }

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
                throw new SemanticError("tipo(s) incompatível(is) em expressão aritmética");
            }

            Codigo += "\nadd";
        }
    }
}
