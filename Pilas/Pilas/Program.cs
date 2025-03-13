using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Elementos obj = new Elementos();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1) Agregar valor.");
                Console.WriteLine("2) Quitar valor.");
                Console.WriteLine("3) Imprimir Pila.");
                Console.WriteLine("4) Limpiar Pila.");
                Console.WriteLine("5) Terminar");
                obj.Op = int.Parse(Console.ReadLine());
                switch (obj.Op)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el valor: ");
                        obj.Valor = int.Parse(Console.ReadLine());
                        if (obj.Valor >= 0)
                        {
                            obj.Pila.Push(obj.Valor);
                            if (obj.Pila.Count > 0)
                            {
                                Console.WriteLine("");
                                foreach (int dato in obj.Pila)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(" | |");
                                    if (dato < 10)
                                    {
                                        Console.WriteLine(" | 0" + dato + " |");
                                    }
                                    else
                                    {
                                        Console.WriteLine(" | " + dato + " |");
                                        Console.WriteLine(" |______|");
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Pila Vacia.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Solo puede introducir numeros enteros.");
                        }
                        break;
                    case 2:
                        if (obj.Pila.Count > 0)
                        {
                            obj.Valor = (int)obj.Pila.Pop();
                            Console.WriteLine("Elemento " + obj.Valor + " eliminado");
                        }
                        else
                        {
                            if (obj.Pila.Count > 0)
                            {
                                Console.WriteLine("");
                                foreach (int dato in obj.Pila)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine(" | |");
                                    if (dato < 10)
                                    {
                                        Console.WriteLine(" | 0" + dato + " |");
                                    }
                                    else
                                    {
                                        Console.WriteLine(" | " + dato +" |");
                                        Console.WriteLine(" |______|");
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Pila Vacia.");
                            }
                        }
                        break;
                    case 3:
                        if (obj.Pila.Count > 0)
                        {
                            Console.WriteLine("");
                            foreach (int dato in obj.Pila)
                            {
                                Console.WriteLine("");
                                Console.WriteLine(" | |");
                                if (dato < 10)
                                {
                                    Console.WriteLine(" | 0" + dato + " |");
                                }
                                else
                                {
                                    Console.WriteLine(" | " + dato + " |");
                                    Console.WriteLine(" |______|");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Pila Vacia.");
                        }
                        break;
                    case 4:
                        obj.Pila.Clear();
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Gracias por utilizar el programa.");
                        Console.ReadKey();
                        break;
                    default: break;
                }
            } while (obj.B1 != 1);
        }
    }
}

