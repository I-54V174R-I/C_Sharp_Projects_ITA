using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsAcciones
{
    class Elementos
    {
        private String caminar, carro, autobus, bici, avion, destino, ubicacion;
        Random rnd = new Random();

public String Destino
{
  get { return destino; }
  set { destino = value; }
}

        public String Avion
        {
            get { return avion; }
            set { avion = value; }
        }

        public String Bici
        {
            get { return bici; }
            set { bici = value; }
        }

        public String Autobus
        {
            get { return autobus; }
            set { autobus = value; }
        }

        public String Carro
        {
            get { return carro; }
            set { carro = value; }
        }

        public String Caminar
        {
            get { return caminar; }
            set { caminar = value; }
        }

        public ConsAcciones(String u, String d){
            Console.WriteLine("Escriba su ubicacion:");
            u = Console.ReadLine();
            Console.WriteLine("Escriba su destino:");
            d = Console.ReadLine();
        }
        public void accion(String p1, String p2){

        }
        public void accion(int p1, int p2){
            Console.WriteLine("Usted va de "+p1+" a "+p2+": "+destino);
        }
    }
}
