using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alumno
{
    class Elementos
    {
        private double c1 = 0, c2 = 0, c3 = 0, promg = 0;

        public double Promg
        {
            get { return promg; }
            set { promg = value; }
        }
        private String nombre, noctrl, carrera;

        public String Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        public String Noctrl
        {
            get { return noctrl; }
            set { noctrl = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double C3
        {
            get { return c3; }
            set { c3 = value; }
        }

        public double C2
        {
            get { return c2; }
            set { c2 = value; }
        }

        public double C1
        {
            get { return c1; }
            set { c1 = value; }
        }
    }
}
