using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                            // Este estado queda pendiente definirlo
                            estado = 2;
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
                        else
                        {
                            if(caracter == '$' && i == entrada.Length - 1)
                            {
                                Console.WriteLine("Analisis exitoso!");
                            }
                            else
                            {
                                auxiliarLexico += caracter;
                                agregarToken(Token.Tipo.Error);
                                Console.WriteLine("Error");
                            }
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
