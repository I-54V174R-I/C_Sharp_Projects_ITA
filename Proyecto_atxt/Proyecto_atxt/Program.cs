using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Proyecto_atxt
{
    class Program
    {
        public void lectura()
        {
            try
            {
                string ruta = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_atxt\atxt.txt";
                StreamReader lector = new StreamReader(ruta);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    Console.WriteLine(linea);
                    linea = lector.ReadLine();
                }
                lector.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Lectura Finalizada.");
                Console.ReadKey();
            }
        }
        public void escritura()
        {
            try
            {
                string ruta = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_atxt\atxt.txt";
                StreamWriter escritor = new StreamWriter(ruta);
                Console.WriteLine("Escriba algo: ");
                string entrada = Console.ReadLine();
                escritor.WriteLine(entrada);
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Escritura Finalizada.");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.escritura();
            p.lectura();
        }
    }
}
