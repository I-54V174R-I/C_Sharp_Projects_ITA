using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elementos obj = new Elementos();
            Random rnd = new Random();
            int cont=0, a=0;
            do{
                do{
                Console.WriteLine("");
                Console.WriteLine("Bienvenid@, a continuacion se muestran 5 opciones:");
                Console.WriteLine("");
                Console.WriteLine("1) Programa 1");
                Console.WriteLine("2) Programa 2");
                Console.WriteLine("3) Programa 3");
                Console.WriteLine("4) Programa 4");               
                Console.WriteLine("");
                Console.WriteLine("Seleccione una.");
                obj.Opcion=int.Parse(Console.ReadLine());
                switch(obj.Opcion){
                    case 1: obj.B4 = 1;
                        do
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Hola, bienvenid@ al programa 1.");
                            Console.WriteLine("Escriba un limite inferior cualquiera:");
                            obj.Liminf = int.Parse(Console.ReadLine());
                            do
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Escriba un limite superior:");
                                obj.Limsup = int.Parse(Console.ReadLine());
                                if (obj.Limsup > obj.Liminf)
                                {
                                    obj.B1 = 1;
                                    Console.WriteLine("");
                                    Console.WriteLine("Ahora escriba un numero entero cualquiera.");
                                    obj.Num = int.Parse(Console.ReadLine());
                                    Console.WriteLine("");
                                    Console.WriteLine("Numero introducido: " + obj.Num + ".");
                                    Console.WriteLine("");
                                    Console.WriteLine("Numeros pares en el rango: ");
                                    Console.WriteLine("");
                                    for (int i = obj.Liminf; i <= obj.Limsup; i++)
                                    {
                                        if (i % 2 == 0)
                                        {
                                            Console.Write(i + ", ");
                                        }
                                    }
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Numeros del rango divisibles entre el numero introducido: ");
                                    Console.WriteLine("");
                                    for (int r = obj.Liminf; r <= obj.Limsup; r++)
                                    {
                                        if (r % obj.Num == 0)
                                        {
                                            Console.Write(r + ", ");
                                        }
                                    }
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    obj.B1 = 0;
                                    Console.WriteLine("");
                                    Console.WriteLine("Por favor, escriba un limite superior que sea mayor al limite inferior.");
                                }
                            } while (obj.B1 != 1);
                            do
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Desea Continuar con el programa 1 (S/N)?");
                                obj.Op = Console.ReadLine();
                                if (obj.Op == "S" || obj.Op == "s")
                                {
                                    obj.B2 = 1;
                                    obj.B3 = 1;
                                }
                                else if (obj.Op == "N" || obj.Op == "n")
                                {
                                    obj.B2 = 1;
                                    obj.B3 = 0;
                                }
                                else
                                {
                                    obj.B2 = 0;
                                    Console.WriteLine("Opcion Invalida, escriba otra vez.");
                                }
                            } while (obj.B2 != 1);
                        } while (obj.B3 != 0);
                        break;
                    case 2: obj.B4 = 1;
                        do{
                            Console.WriteLine("");
                            Console.WriteLine("Hola, bienvenid@ al programa 2.");
                            Console.WriteLine("Escriba un numero entero:");
                            obj.N1=double.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            Console.WriteLine("Escriba otro numero entero:");
                            obj.N2=double.Parse(Console.ReadLine());
                            obj.Med=(obj.N1+obj.N2)/2;
                            Console.WriteLine("");
                            Console.WriteLine("El numero que se encuentra a la mitad es el "+obj.Med+".");
                            do
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Desea Continuar con el programa 2 (S/N)?");
                                obj.Op2 = Console.ReadLine();
                                if (obj.Op2 == "S" || obj.Op2 == "s")
                                {
                                    obj.B6 = 1;
                                    obj.B7 = 1;
                                }
                                else if (obj.Op2 == "N" || obj.Op2 == "n")
                                {
                                    obj.B6 = 1;
                                    obj.B7 = 0;
                                }
                                else
                                {
                                    obj.B6 = 0;
                                    Console.WriteLine("Opcion Invalida, escriba otra vez.");
                                }
                            } while (obj.B6 != 1);
                        } while (obj.B7 != 0);
                        break;
                    case 3: obj.B4 = 1;
                        do{
                            Console.WriteLine("");
                            Console.WriteLine("Hola, bienvenid@ al programa 3.");
                            do{
                            Console.WriteLine("Escriba un numero entero:");
                            obj.Intprimo=int.Parse(Console.ReadLine());
                                if(obj.Intprimo>0){
                                    obj.Bprim=1;
                                    Console.WriteLine("Los numeros primos en el rango son: ");
                                    Console.WriteLine("");
                                    for (int i = 2; i <= obj.Intprimo; i++){ 
                                        for (int j = 1; j <= i; j++){ 
                                            if (i % j == 0){ 
                                                cont = cont + 1;
                                            }
                                        }
                                        if (cont <= 2){ 
                                            Console.Write(i+", ");
                                        }     
                                        cont = 0;              
                                        
                                    }
                                }else{
                                    obj.Bprim=0;
                                    Console.WriteLine("");
                                    Console.WriteLine("Numero invalido, escriba un numero positivo mayor a cero.");
                                }
                            }while(obj.Bprim!=1);
                            do{
                                Console.WriteLine("");
                                    Console.WriteLine("");
                                Console.WriteLine("Desea Continuar con el programa 3 (S/N)?");
                                obj.Op3 = Console.ReadLine();
                                if (obj.Op3 == "S" || obj.Op3 == "s")
                                {
                                    obj.B8 = 1;
                                    obj.B9 = 1;
                                }
                                else if (obj.Op3 == "N" || obj.Op3 == "n")
                                {
                                    obj.B8 = 1;
                                    obj.B9 = 0;
                                }
                                else
                                {
                                    obj.B8 = 0;
                                    Console.WriteLine("Opcion Invalida, escriba otra vez.");
                                }
                            } while (obj.B8 != 1);
                        } while (obj.B9 != 0);
                        break;
                    case 4: obj.B4 = 1;
                        do{
                            Console.WriteLine("Oprima una tecla para continuar...");
                            Console.ReadKey();
                            a = 0;
                            int noalt = rnd.Next(1, 100);
                            Console.WriteLine("");
                            Console.WriteLine("El no aleatorio es: " + noalt);
                            if (noalt % 2 == 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("El numero "+noalt+" es par.");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("El numero "+noalt+" no es par.");
                            }
                            for (int i = 1; i < (noalt + 1); i++)
                            {
                                if (noalt % i == 0)
                                {
                                    a++;
                                }
                            }
                            if (a != 2)
                            {
                                Console.WriteLine("El numero no es Primo");
                            }
                            else
                            {
                                Console.WriteLine("El numero es Primo");
                            }
                            do
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Desea Continuar con el programa 4 (S/N)?");
                                obj.Op4 = Console.ReadLine();
                                if (obj.Op4 == "S" || obj.Op4 == "s")
                                {
                                    obj.B10 = 1;
                                    obj.B11 = 1;
                                }
                                else if (obj.Op4 == "N" || obj.Op4 == "n")
                                {
                                    obj.B10 = 1;
                                    obj.B11 = 0;
                                }
                                else
                                {
                                    obj.B10 = 0;
                                    Console.WriteLine("Opcion Invalida, escriba otra vez.");
                                }
                            } while (obj.B10 != 1);
                        } while (obj.B11 != 0);
                        break;
                    default: obj.B4 = 0;
                        Console.WriteLine("Opcion Invalida, escribe otra vez.");
                        break;
                }
            }while(obj.B4!=1);
                do{
                Console.WriteLine("Desea continuar (S/N)?");
                obj.Op2=Console.ReadLine();
                                if (obj.Op2 == "S" || obj.Op2 == "s")
                                {
                                    obj.B5 = 1;
                                    obj.X = 1;
                                }
                                else if (obj.Op2 == "N" || obj.Op2 == "n")
                                {
                                    obj.B5 = 1;
                                    obj.X = 0;
                                }
                                else
                                {
                                    obj.B5 = 0;
                                    Console.WriteLine("Opcion Invalida, escriba otra vez.");
                                }
                }while(obj.B5!=1);                
            }while(obj.X!=0);
        }
    }
}
