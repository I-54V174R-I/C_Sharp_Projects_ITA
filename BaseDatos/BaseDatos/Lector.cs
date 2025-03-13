using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;


namespace BaseDatos
{
    class Lector
    {
        public ArrayList Registros = new ArrayList();
        public Lector() {
            this.Registros = new ArrayList();
        }
        public void leer(){
            try {
                StreamReader Lector = new StreamReader("C:\\Users\\MarioAlejandro\\Desktop\\Programas C#\\Proyecto_at\\atxt.txt");
                String lineas = Lector.ReadLine();
                char[] delimitador = { ';' };
                String[] palabra = lineas.Split(delimitador);

                Estudiante e = new Estudiante();
                e.NC=palabra[0];
                e.nombre = palabra[1];
                e.correo = palabra[2];
                e.domicilio = palabra[3];
                e.telefono = palabra[4];

                Registros.Add(e);
                lineas = Lector.ReadLine();
                Lector.Close();
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally {
                Console.WriteLine("Finalizado.");
                Console.ReadKey();
            }
        }
        public void ejecutar() { }
    }
}
