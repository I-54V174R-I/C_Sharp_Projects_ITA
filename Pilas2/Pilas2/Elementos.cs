using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Pilas2
{
    class Elementos
    {
        private Stack pila = new Stack();
        private int b1, b2, valor1, valor2, operador;

        public int Operador
        {
            get { return operador; }
            set { operador = value; }
        }

        public int Valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }

        public int Valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }

        public Stack Pila
        {
            get { return pila; }
            set { pila = value; }
        }

    }
}
