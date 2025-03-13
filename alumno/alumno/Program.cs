using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alumno
{
    class Program
    {
        static void Main(string[] args)
        {
            double c1, c2, c3;
            Elementos obj = new Elementos();
            Console.WriteLine("");
            Console.WriteLine("Escriba su no de control: ");
            obj.Noctrl = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Escriba su nombre: ");
            obj.Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Escribe tu carrera: ");
            obj.Carrera = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Escribe 1a calificacion: ");
            obj.C1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Escribe 2a calificacion: ");
            obj.C2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Escribe 3a calificacion: ");
            obj.C3 = Convert.ToDouble(Console.ReadLine());
            obj.Promg = (obj.C1 + obj.C2 + obj.C3)/3;
            if(obj.C1>=70){}else{}
            Console.WriteLine("Su promedio fue: "+obj.Promg);
            Console.ReadKey();
        }
    }
}
