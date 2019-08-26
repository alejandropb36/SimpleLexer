using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLexer
{
    class Token
    {
        public enum Tipo
        {
            Eror = -1,
            Tipo,
            PuntoComa,
            Coma,
            ParentesisIzquierdo,
            ParentesisDerecho,
            LlaveIzquierda,
            LlaveDerecha,
            Igual,
            If,
            While,
            Return,
            Else,
            Constante,
            OperadorSuma,
            OperadorNot,
            OperadorMultiplicador,
            OperadorRel,
            OperadorIgualdad,
            OperadorAnd,
            OperadorOr,
            Pesos
        }
        private Tipo tipoToken;
        private string valor;

        public Token(Tipo tipoToken, string valor)
        {
            this.tipoToken = tipoToken;
            this.valor = valor;
        }

        public string Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                this.valor = value;
            }
        }

        public string GetTipoToken()
        {
            switch (tipoToken)
            {
                case Tipo.Eror:
                    return "Error";
                case Tipo.Tipo:
                    return "Tipo";
                case Tipo.PuntoComa:
                    return "Punto y coma";
                case Tipo.Coma:
                    return "Coma";
                case Tipo.ParentesisIzquierdo:
                    return "Parentesis izquierdo";
                case Tipo.ParentesisDerecho:
                    return "Parentesis derecho";
                case Tipo.LlaveIzquierda:
                    return "Llave izquierda";
                case Tipo.LlaveDerecha:
                    return "Llave derecha";
                case Tipo.Igual:
                    return "Igual";
                case Tipo.If:
                    return "If";
                case Tipo.While:
                    return "While";
                case Tipo.Return:
                    return "Return";
                case Tipo.Else:
                    return "Else";
                case Tipo.Constante:
                    return "Constante";
                case Tipo.OperadorSuma:
                    return "Operadores de suma";
                case Tipo.OperadorNot:
                    return "Operador Not";
                case Tipo.OperadorMultiplicador:
                    return "Operadores multiplicadores";
                case Tipo.OperadorRel:
                    return "Operador rel";
                case Tipo.OperadorIgualdad:
                    return "Igualdad";
                case Tipo.OperadorAnd:
                    return "AND";
                case Tipo.OperadorOr:
                    return "OR";
                case Tipo.Pesos:
                    return "Pesos";
                default:
                    return "Error";
            }
        }

        
    }
}
