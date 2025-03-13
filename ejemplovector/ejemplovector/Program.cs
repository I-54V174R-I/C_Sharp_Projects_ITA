using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemplovector
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nos = new int [10];
            int sumapares=0, sumaimpares=0, suma=0;
                for(int i=0;i<=nos.Length-1;i++){
                Console.WriteLine("Introduzca el numero de la posicion "+i);
                    nos[i]=int.Parse(Console.ReadLine());
                    suma = suma + nos[i];
                    if(nos[i]%2==0){
                        sumapares=sumapares+nos[i];
                    }else{
                        sumaimpares=sumaimpares+nos[i];
                    }
                }
            //limpiar o quitar
            for(int a=0 ; a<=nos.Length-1; a++){
                nos[a]=0;
            }
            //Comprobar pila vacia (true o false)
            //Comprobar pila llena (T o F)

                    Console.WriteLine("");
                Console.WriteLine("Suma Pares: "+sumapares);
                Console.WriteLine("Suma Impares: " + sumaimpares);
                Console.WriteLine("Suma Total: " + suma);
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("Numeros en orden ascendente:");
                for (int g = 0; g <= nos.Length-1; g++)
                {
                    Console.WriteLine(nos[g]);
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("Numeros en orden descendente:");
                for (int r = 9; r >= 0; r--)
                {
                    Console.WriteLine(nos[r]);
                }
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
        }
    }
}
