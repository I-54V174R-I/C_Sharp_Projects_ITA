using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Pilas
{
    class Elementos
    {
        private int valor, b1, b2, op;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int Op
        {
            get { return op; }
            set { op = value; }
        }

        public int B2
        {
            get { return b2; }
            set { b2 = value; }
        }

        public int B1
        {
            get { return b1; }
            set { b1 = value; }
        }
        private Stack pila = new Stack();

        public Stack Pila
        {
            get { return pila; }
            set { pila = value; }
        }

    }
}
