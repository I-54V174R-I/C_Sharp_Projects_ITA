using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NomPeso
{
    class Class
    {
        private String nombre;
        private int peso;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Class(String nom, int peso)
        {
            Console.WriteLine("Introduzca su nombre:");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su peso (en kg).");
            this.peso = int.Parse(Console.ReadLine());
        }

        public void ActualizarDatos(String nom, int peso) 
        {
            Console.WriteLine("Introduzca su nombre:");
            nom = Console.ReadLine();
            Console.WriteLine("Introduzca su peso (en kg).");
            peso = int.Parse(Console.ReadLine());
        }

        public void ActualizarDatos(String nom)
        {
            Console.WriteLine("Introduzca su nombre:");
            nom = Console.ReadLine();
        }

        public void ActualizarDatos(int peso)
        {
            Console.WriteLine("Introduzca su peso (en kg).");
            peso = int.Parse(Console.ReadLine());
        }

        public void ActualizarDatos(int peso, String nom)
        {
            Console.WriteLine("Introduzca su peso (en kg).");
            peso = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Introduzca su nombre:");
            nom = Console.ReadLine();
        }
~Class()
{
            Console.Write("");
            Console.ReadKey();
}
    }
}
