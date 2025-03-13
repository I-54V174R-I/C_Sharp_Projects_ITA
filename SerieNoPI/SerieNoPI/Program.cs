using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerieNoPI
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
                obj.Res = 0;
                obj.Respares = 0;
                obj.Resimpares = 0;
                Console.WriteLine("");
                Console.WriteLine("Escriba un numero del cual quiere saber su serie: ");
                obj.N = Convert.ToInt32(Console.ReadLine());
                if (obj.N != 0)
                {
                    obj.B = 1;
                    Console.WriteLine("La serie numerica del " + obj.N + " es: ");
                    Console.WriteLine("");
                    for (int i = 1; i <= 10; i++)
                    {
                        obj.Res = obj.N * i;
                        Console.WriteLine(obj.N + " * " + i + " = " + obj.Res);
                        Console.WriteLine("");
                    }
                    for (int h = 1; h <= 10; h++)
                    {
                        obj.Res = obj.N * h;
                        if(obj.Res%2==0){
                        obj.Respares = obj.Respares + obj.Res;
                    }else if(obj.Res%2!=0){
                        obj.Resimpares = obj.Resimpares + obj.Res;
                    }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("La suma de los nos pares de la serie es: "+obj.Respares);
                    Console.WriteLine("");
                    Console.WriteLine("La suma de los nos impares de la serie es: "+obj.Resimpares);
                    Console.WriteLine("");
                    Console.ReadKey();
                }
                else
                {
                    obj.B = 0;
                    Console.WriteLine("Por favor, escriba un numero valido.");
                }
            } while (obj.B != 1);
            Console.WriteLine("");
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
