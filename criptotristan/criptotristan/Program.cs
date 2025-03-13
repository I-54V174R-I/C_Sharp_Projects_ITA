using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace criptotristan
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1, b2, x=2, np, op, cont=0;
            long nm1, nm2, mod;
            String op1;
            do{
            do{
                Console.WriteLine("");
                Console.WriteLine("Selecciona que quieres hacer: ");
                Console.WriteLine("");
                Console.WriteLine("1) Si N es Primo");
                Console.WriteLine("2) Modulo de una division de 2 nos");
                op=int.Parse(Console.ReadLine());
                switch (op){
                    case 1: b1=1;
                        Console.WriteLine("Introduzca su numero: ");
                        np = int.Parse(Console.ReadLine());
                        for (int i=0; i<=2; i++ ) {
                            if(np%2==0){
                                cont = cont + 1;
                            }
                        }
                        if (cont <= 2)
                        {
                            Console.WriteLine("Su numero " + np + " es Primo.");
                        }
                        else
                        {
                            Console.WriteLine("Su numero " + np + " no es Primo.");
                        }
                        break;
                    case 2: b1 = 1;
                        Console.WriteLine("Introduzca 1er No: ");
                        nm1 = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Introduzca 2o No: ");
                        nm2 = Convert.ToInt64(Console.ReadLine());
                        mod = nm1 % nm2;
                        Console.WriteLine("");
                        Console.WriteLine("El modulo de "+nm1+" y "+nm2+" es: "+mod);
                        break;
                    default: b1=0;
                        Console.WriteLine("");
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            } while (b1 != 1);
                do{
            Console.WriteLine("");
            Console.WriteLine("Desea Continuar(S/N)?");
            op1 = Console.ReadLine();
                if(op1=="S" || op1=="s")
                {
                    b2 = 1;
                    x = 1;
                }
                else if (op1 == "N" || op1 == "n")
                {
                    b2 = 1;
                    x = 0;
                }
                else
                {
                    b2 = 0;
                    Console.WriteLine("Opcion Invalida.");
                }
            }while(b2!=1);
            }while(x!=0);
        }
    }
}
