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
        private string auxiliarLexico;
        
        public LinkedList<Token> analizar(string entrada)
        {
            entrada = entrada + "$";
            tokens = new LinkedList<Token>();
            estado = 0;
            auxiliarLexico = "";
            char caracter;

            for(int i = 0; i < entrada.Length; i++)
            {
                caracter = entrada.ElementAt(i);
                switch (estado)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;

                }
            }

           

            return tokens;

        }

    }
}
