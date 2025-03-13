using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Elementos obj = new Elementos();
            do
            {
            do
            {
                obj.Res = 1;
                Console.WriteLine("");
                Console.WriteLine("Buen dia");
                Console.WriteLine("Por favor ingrese un numero del cual quiere saber su factorial: ");
                obj.N = Convert.ToInt32(Console.ReadLine());
                if (obj.N >= 0)
                {
                    obj.B1 = 1;
                    Console.Write("El factorial de " + obj.N + " es: ");
                    for (int i = obj.N; i >= 1; i--)
                    {
                        obj.Res = obj.Res * i;
                        Console.Write(i + " * ");
                    }
                    Console.WriteLine(" = " + obj.Res);
                    Console.ReadKey();
                }
                else
                {
                    obj.B1 = 0;
                    Console.WriteLine("Por favor, escriba un numero igual o mayor a cero.");
                }
              }while (obj.B1 != 1);
            Console.WriteLine("Deseas ingresar otro numero(S/N)?");
            obj.Op = Console.ReadLine();
                if(obj.Op=="S" || obj.Op=="s"){
                    obj.B2=1;
                }
                else if (obj.Op == "N" || obj.Op == "n")
                {
                    obj.B2=0;
                }
            }while(obj.B2 !=0);
        }
    }
}
