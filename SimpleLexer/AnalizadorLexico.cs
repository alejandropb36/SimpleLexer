using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleLexer
{
    class AnalizadorLexico
    {
        private LinkedList<Token> tokens;
        private int estado;
        private String auxiliarLexico;
        
        public LinkedList<Token> analizar(string entrada)
        {
            entrada = entrada + "$";
            tokens = new LinkedList<Token>();
            estado = 0;
            auxiliarLexico = "";
            Char caracter;
            Regex palabrasReservadas = new Regex(@"(int)|(float)|(string)|(char)|(return)|(main)|(for)|(while)|(if)|(else)");


            for(int i = 0; i < entrada.Length; i++)
            {
                caracter = entrada.ElementAt(i);
                switch (estado)
                {
                    case 0:
                        if (char.IsDigit(caracter))
                        {
                            estado = 1;
                            auxiliarLexico += caracter;
                        }
                        else if (char.IsLetter(caracter))
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                        }
                        else if(caracter == '_')
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                        }
                        else if(caracter == ';')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.PuntoComa);
                        }
                        else if (caracter == ',')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.Coma);
                        }
                        else if (caracter == '(')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.ParentesisIzquierdo);
                        }
                        else if (caracter == ')')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.ParentesisDerecho);
                        }
                        else if (caracter == '{')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.LlaveIzquierda);
                        }
                        else if (caracter == '}')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.LlaveDerecha);
                        }
                        else if (caracter == '*')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorMultiplicador);
                        }
                        else if (caracter == '/')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorMultiplicador);
                        }
                        else if (caracter == '+')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorSuma);
                        }
                        else if (caracter == '-')
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.OperadorSuma);
                        }
                        else if (caracter == '!')
                        {
                            estado = 4;
                            auxiliarLexico += caracter;
                        }
                        else if (caracter == '=')
                        {
                            estado = 4;
                            auxiliarLexico += caracter;
                        }
                        else if (caracter == '&')
                        {
                            estado = 4;
                            auxiliarLexico += caracter;
                        }
                        else if (caracter == '|')
                        {
                            estado = 4;
                            auxiliarLexico += caracter;
                        }
                        else if (caracter == '>')
                        {
                            estado = 4;
                            auxiliarLexico += caracter;
                        }
                        else if (caracter == '<')
                        {
                            estado = 4;
                            auxiliarLexico += caracter;
                        }
                        else
                        {
                            
                        }
                        break;
                    case 1:
                        if (char.IsDigit(caracter))
                        {
                            estado = 1;
                            auxiliarLexico += caracter;
                        }
                        else if(caracter == '.')
                        {
                            estado = 2;
                            auxiliarLexico += caracter;
                        }
                        else if(caracter == ' ')
                        {
                            agregarToken(Token.Tipo.Constante);
                        }
                        break;
                    case 2:
                        if (char.IsDigit(caracter))
                        {
                            estado = 2;
                            auxiliarLexico += caracter;
                        }
                        else if(char.IsLetter(caracter))
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                        }
                        else
                        {
                            auxiliarLexico += caracter;
                            agregarToken(Token.Tipo.Error);
                        }
                        break;
                    case 3:
                        if (char.IsLetter(caracter))
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                            if (palabrasReservadas.IsMatch(auxiliarLexico))
                            {
                                agregarToken(Token.Tipo.Tipo);
                            }
                        }
                        else if (char.IsDigit(caracter))
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                        }
                        else if(caracter == '_')
                        {
                            estado = 3;
                            auxiliarLexico += caracter;
                        }
                        else if(caracter == ' ')
                        {
                            agregarToken(Token.Tipo.Constante);
                        }
                        else
                        {
                            agregarToken(Token.Tipo.Error);
                        }
                        break;

                    case 4:
                        if(caracter == '=')
                        {
                            auxiliarLexico += caracter;
                            if(auxiliarLexico == "==")
                            {
                                agregarToken(Token.Tipo.OperadorIgualdad);
                            }
                            else if(auxiliarLexico == "!=" )
                            {
                                agregarToken(Token.Tipo.OperadorRel);
                            }
                            else if (auxiliarLexico == "<=")
                            {
                                agregarToken(Token.Tipo.OperadorRel);
                            }
                            else if (auxiliarLexico == ">=")
                            {
                                agregarToken(Token.Tipo.OperadorRel);
                            }
                            else
                            {
                                agregarToken(Token.Tipo.Error);
                            }
                        }
                        else if (caracter == '&')
                        {
                            auxiliarLexico += caracter;
                            if(auxiliarLexico == "&&")
                            {
                                agregarToken(Token.Tipo.OperadorAnd);
                            }
                            else
                            {
                                agregarToken(Token.Tipo.Constante);
                            }
                        }
                        else if (caracter == '|')
                        {
                            auxiliarLexico += caracter;
                            if (auxiliarLexico == "||")
                            {
                                agregarToken(Token.Tipo.OperadorOr);
                            }
                            else
                            {
                                agregarToken(Token.Tipo.Constante);
                            }
                        }
                        else if (caracter == ' ')
                        {
                            if (auxiliarLexico == "=")
                            {
                                agregarToken(Token.Tipo.Igual);
                            }
                            else
                            {
                                agregarToken(Token.Tipo.Constante);
                            }
                        }
                        else
                        {
                            if(auxiliarLexico == "!")
                            {
                                if (caracter == ' ')
                                {
                                    agregarToken(Token.Tipo.OperadorNot);
                                }
                            }
                            else if (caracter == ' ')
                            {
                                agregarToken(Token.Tipo.Constante);
                            }
                        }
                        break;
                    default:
                        agregarToken(Token.Tipo.Error);
                        break;

                }
            }

           

            return tokens;

        }

        public void agregarToken(Token.Tipo tipo)
        {
            tokens.AddLast(new Token(tipo, auxiliarLexico));
            auxiliarLexico = "";
            estado = 0;
        }

    }
}
