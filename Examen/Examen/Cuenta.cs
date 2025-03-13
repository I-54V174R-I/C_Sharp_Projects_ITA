using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen
{
    class Cuenta
    {
        static void Main(string[] args)
        {
            Elementos obj = new Elementos();
            do{
                do{
                Console.WriteLine("");
                Console.WriteLine("Buen dia, seleccione un movimiento:");
                Console.WriteLine("");
                Console.WriteLine("1)Deposito");
                Console.WriteLine("2)Retiro");
                Console.WriteLine("");
                Console.WriteLine("Su saldo actual: $"+obj.Balance);
                obj.Op=int.Parse(Console.ReadLine());
                if (obj.Op == 1)
                {
                    obj.B1 = 1;
                    obj._deposito();
                    obj.Cont = obj.Cont + 1;
                }
                else if (obj.Op == 2)
                {
                    obj.B1 = 1;
                    obj._retiro();
                    obj.Cont = obj.Cont + 1;                                      
                    }
                else
                {
                    obj.B1 = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Opcion Invalida, por favor escriba una opcion correcta.");
                }
            }while(obj.B1!=1);
                do
                {
                    Console.WriteLine("");
                Console.WriteLine("Desea realizar otra transaccion(S/N).");
                obj.Op1 = Console.ReadLine();
                if(obj.Op1=="S" || obj.Op1=="s")
                {
                    obj.B2 = 1;
                    obj.X = 1;

                }
                else if (obj.Op1 == "N" || obj.Op1 == "n")
                {
                    obj.B2 = 1;
                    obj.X = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Saldo final de la cuenta: $" + obj.Balance);
                    Console.WriteLine("Movimientos realizados: "+ obj.Cont);
                    Console.ReadKey();

                }
                else
                {
                    obj.B2 = 0;
                    Console.WriteLine("");
                    Console.WriteLine("Opcion Invalida, escriba una opbion correcta.");
                }
                }while(obj.B2!=1);
            }while(obj.X!=0);
        }
    }
}
