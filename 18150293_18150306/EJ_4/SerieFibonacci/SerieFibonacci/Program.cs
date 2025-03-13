using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerieFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Elementos obj = new Elementos();
            do{
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Escriba cuantos numeros de la serie de Fibonacci desea ver: ");
                    obj.Nter = Convert.ToInt32(Console.ReadLine());
                    if (obj.Nter > 0)
                    {
                        Console.WriteLine("Los " + obj.Nter + " primeros terminos de la serie de Fibonacci son: ");
                        obj.B1 = 1;
                        obj.A = 0;
                        obj.B = 1;
                        for (int i = 0; i < obj.Nter; i++)
                        {
                            obj.Ar = obj.A;
                            Console.Write(obj.A + ", ");
                            obj.A = obj.B;
                            obj.B = obj.Ar + obj.A;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Las respectivas sumas son: ");
                        Console.WriteLine("");
                        obj.A = 0;
                        obj.B = 1;
                        for (int r = 0; r < obj.Nter; r++)
                        {
                            obj.Ar = obj.A;
                            obj.A = obj.B;
                            obj.B = obj.Ar + obj.A;
                            Console.WriteLine(obj.Ar + " + " + obj.A + " = " + obj.B);
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        obj.B1 = 0;
                        Console.WriteLine("Por favor, escriba un numero valido.");
                    }
                } while (obj.B1 != 1);
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
