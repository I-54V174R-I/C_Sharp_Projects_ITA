using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tenclase
{
    class Elementos
    {
        private string noctrl;

        public string Noctrl
        {
            get { return noctrl; }
            set { noctrl = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private double prom;

        public double Prom(double p1, double p2, double p3)
        {
            prom = p1 + p2 + p3 / 3;
            return prom;
        }
    }
}
