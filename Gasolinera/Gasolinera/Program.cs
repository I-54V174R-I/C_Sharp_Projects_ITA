using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gasolinera
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            //captura informacion del vehiculo
            obj.X = 2;
            Console.WriteLine("");
            Console.WriteLine("Buen dia");
            Console.WriteLine("Ingresa tu nombre:");
            obj.Nombre = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Propociona la marca de su vehiculo:");
            obj.Marca = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Registre la placa de su vehiculo:");
            obj.Placa = Console.ReadLine();            
            do{
                do
                {
                    do
                    {
                        //Capturar datos de la carga de gasolina
                        obj.Recorrido = 0;
                        obj.Rendimiento = 0;
                        Console.WriteLine("");
                        Console.WriteLine("seleccione el tipo de gasolina que desea cargar");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("1) verde----$20.09");
                        Console.WriteLine("2) roja-----$24.89");
                        Console.WriteLine("3) diesel---$23.98");

                        obj.Opc = int.Parse(Console.ReadLine());
                        switch (obj.Opc)
                        {

                            case 1: obj.B1 = 1;
                                do{
                                    Console.WriteLine("");
                                    Console.WriteLine("Usted escogio: Verde----$20.09");
                                Console.WriteLine("¿Cuantos litros desea cargar?");
                                obj.Lts = int.Parse(Console.ReadLine());
                                if (obj.Lts > 0)
                                {
                                    obj.B6 = 1;
                                    obj.Tot = obj.Verde * obj.Lts;
                                    do
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Por favor, ingrese el kilometraje actual:");
                                        Console.WriteLine("Su kilometraje anterior: " + obj.Kmant + " km.");
                                        obj.Kmact = Convert.ToInt32(Console.ReadLine());
                                        if (obj.Kmact > obj.Kmant)
                                        {
                                            obj.B2 = 1;
                                            Console.WriteLine("");
                                            Console.WriteLine("Introduzca la fecha(dd/mm/aaaa):");
                                            obj.Fecha = Console.ReadLine();
                                            obj.Recorrido = obj.Kmact - obj.Kmant;
                                            obj.Rendimiento = obj.Recorrido / obj.Lts;
                                            obj.Kmant = obj.Kmant + obj.Kmact;
                                            Console.WriteLine("");
                                            Console.WriteLine("Datos del cliente:");
                                            Console.WriteLine("Nombre: " + obj.Nombre + ".");
                                            Console.WriteLine("Marca: " + obj.Marca + ".");
                                            Console.WriteLine("Placa: " + obj.Placa + ".");
                                            Console.WriteLine("Total a Pagar: $"+obj.Tot+".");
                                            Console.WriteLine("Fecha de la compra: "+obj.Fecha+".");
                                            Console.WriteLine("Kilometraje recorrido: "+obj.Recorrido+" km.");
                                            Console.WriteLine("Rendimiento: "+obj.Rendimiento+" km/lt.");
                                        }
                                        else
                                        {
                                            obj.B2 = 0;
                                            Console.WriteLine("Error, el kilometraje introducido debe ser mayor al kilometraje anterior.");
                                            Console.WriteLine("Su kilometraje anterior fue: " + obj.Kmant + " km.");
                                        }
                                    } while (obj.B2 != 1);

                                }
                                else
                                {
                                    obj.B6 = 0;
                                Console.WriteLine("");
                                        Console.WriteLine("Error, por favor escriba una cantidad valida.");
                                    }
                                }while(obj.B6!=1);
                                break;
                            case 2: obj.B1 = 1;
                                    do
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Usted escogio: Roja-----$24.89");
                                Console.WriteLine("¿Cuantos litros desea cargar?");
                                obj.Lts = int.Parse(Console.ReadLine());
                                if (obj.Lts > 0) {
                                    obj.B7 = 1;
                                    obj.Tot = obj.Roja * obj.Lts;
                                    do
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Por favor, ingrese el kilometraje actual:");
                                        Console.WriteLine("Su kilometraje anterior: " + obj.Kmant + " km.");
                                        obj.Kmact = Convert.ToInt32(Console.ReadLine());
                                        if (obj.Kmact > obj.Kmant)
                                        {
                                            obj.B3 = 1;
                                            Console.WriteLine("");
                                            Console.WriteLine("Introduzca la fecha(dd/mm/aaaa):");
                                            obj.Fecha = Console.ReadLine();
                                            obj.Recorrido = obj.Kmact - obj.Kmant;
                                            obj.Rendimiento = obj.Recorrido / obj.Lts;
                                            obj.Kmant = obj.Kmant + obj.Kmact;
                                            Console.WriteLine("");
                                            Console.WriteLine("Datos del cliente:");
                                            Console.WriteLine("Nombre: " + obj.Nombre + ".");
                                            Console.WriteLine("Marca: " + obj.Marca + ".");
                                            Console.WriteLine("Placa: " + obj.Placa + ".");
                                            Console.WriteLine("Total a Pagar: $" + obj.Tot + ".");
                                            Console.WriteLine("Fecha de la compra: " + obj.Fecha + ".");
                                            Console.WriteLine("Kilometraje recorrido: " + obj.Recorrido + " km.");
                                            Console.WriteLine("Rendimiento: " + obj.Rendimiento + " km/lt.");
                                        }
                                        else
                                        {
                                            obj.B3 = 0;
                                            Console.WriteLine("");
                                            Console.WriteLine("Error, el kilometraje introducido debe ser mayor al kilometraje anterior.");
                                            Console.WriteLine("Su kilometraje anterior fue: " + obj.Kmant + " km.");
                                        }
                                    } while (obj.B3 != 1);
                                } else {
                                    obj.B7 = 0;
                                    Console.WriteLine("");
                                    Console.WriteLine("Error, por favor escriba una cantidad valida.");
                                }
                                    }while(obj.B7!=1);
                                break;
                            case 3: obj.B1 = 1;
                                    do
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Usted escogio: Diesel---$23.98");
                                Console.WriteLine("¿Cuantos litros desea cargar?");
                                obj.Lts = int.Parse(Console.ReadLine());
                                if (obj.Lts > 0)
                                {
                                    obj.B8 = 1;
                                    obj.Tot = obj.Diesel * obj.Lts;
                                    do
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("Por favor, ingrese el kilometraje actual:");
                                        Console.WriteLine("Su kilometraje anterior: " + obj.Kmant + " km.");
                                        obj.Kmact = Convert.ToInt32(Console.ReadLine());
                                        if (obj.Kmact > obj.Kmant)
                                        {
                                            obj.B4 = 1;
                                            Console.WriteLine("");
                                            Console.WriteLine("Introduzca la fecha(dd/mm/aaaa):");
                                            obj.Fecha = Console.ReadLine();
                                            obj.Recorrido = obj.Kmact - obj.Kmant;
                                            obj.Rendimiento = obj.Recorrido / obj.Lts;
                                            obj.Kmant = obj.Kmant + obj.Kmact;
                                            Console.WriteLine("");
                                            Console.WriteLine("Datos del cliente:");
                                            Console.WriteLine("Nombre: " + obj.Nombre + ".");
                                            Console.WriteLine("Marca: " + obj.Marca + ".");
                                            Console.WriteLine("Placa: " + obj.Placa + ".");
                                            Console.WriteLine("Total a Pagar: $" + obj.Tot + ".");
                                            Console.WriteLine("Fecha de la compra: " + obj.Fecha + ".");
                                            Console.WriteLine("Kilometraje recorrido: " + obj.Recorrido + " km.");
                                            Console.WriteLine("Rendimiento: " + obj.Rendimiento + " km/lt.");
                                        }
                                        else
                                        {
                                            obj.B4 = 0;
                                            Console.WriteLine("");
                                            Console.WriteLine("Error, el kilometraje introducido debe ser mayor al kilometraje anterior.");
                                            Console.WriteLine("Su kilometraje anterior fue: "+obj.Kmant+" km.");
                                        }
                                    } while (obj.B4 != 1);
                                }
                                else
                                {
                                    obj.B8 = 0;
                                    Console.WriteLine("");
                                    Console.WriteLine("Error, por favor escriba una cantidad valida.");
                                }
                                    }while(obj.B8!=1);
                                break;
                            default:
                                obj.B1 = 0;
                                Console.WriteLine("");
                                Console.WriteLine("Por favor, escriba una opcion valida.");
                                break;
                        }
                    } while (obj.B1 != 1);
                    Console.WriteLine("");
                    Console.WriteLine("Desea continuar(S/N)?");
                    obj.Conf = Console.ReadLine();
                    if (obj.Conf == "S" || obj.Conf == "s")
                    {
                        obj.B5 = 1;
                        obj.X = 1;
                    }
                    else if (obj.Conf == "N" || obj.Conf == "n")
                    {
                        obj.B5 = 2;
                        obj.X = 0;
                    }
                    else
                    {
                        obj.B5 = 0;
                        Console.WriteLine("Opcion invalida, introduzca otra vez.");
                    }
                } while (obj.B5 != 2);
            } while (obj.X != 0);
        }
    }
}
