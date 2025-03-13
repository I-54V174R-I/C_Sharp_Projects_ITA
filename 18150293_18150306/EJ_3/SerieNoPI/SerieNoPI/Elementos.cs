using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerieNoPI
{
    class Elementos
    {
        private int n;

        public int N
        {
            get { return n; }
            set { n = value; }
        }
        private int b;

        public int B
        {
            get { return b; }
            set { b = value; }
        }
        private int res;

        public int Res
        {
            get { return res; }
            set { res = value; }
        }
        private int pares;

        public int Pares
        {
            get { return pares; }
            set { pares = value; }
        }
        private int impares;

        public int Impares
        {
            get { return impares; }
            set { impares = value; }
        }
        private int respares;

        public int Respares
        {
            get { return respares; }
            set { respares = value; }
        }
        private int resimpares;

        public int Resimpares
        {
            get { return resimpares; }
            set { resimpares = value; }
        }
        private int b2;
        public int B2
        {
            get { return b2; }
            set { b2 = value; }
        }
        private String op;

        public String Op
        {
            get { return op; }
            set { op = value; }
        }
    }
}
