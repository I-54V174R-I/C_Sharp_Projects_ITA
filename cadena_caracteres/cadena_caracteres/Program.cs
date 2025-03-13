using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cadena_caracteres{

    class Program{

        public static void Main(string[] args){

            Metodos ob_metodos = new Metodos();
            String frase;

            Console.Write("Escriba una oracion: ");
            frase = Console.ReadLine();
            int[] cpal = Metodos.cantPalabras(frase);
            Console.WriteLine("La frase tiene {0} palabras", cpal[0]);
            Console.WriteLine("La frase tiene {0} vocales", cpal[1]);
            Console.WriteLine("La frase tiene {0} consonantes", cpal[2]);
            Console.ReadKey();
        }   
    }
}
