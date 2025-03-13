using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Proyecto_at
{
    class Elementos
    {
        private int op, x, b1, b2, b3, b4, af=0;
        private ArrayList registros = new ArrayList();
        private String[] id = new String[10];
        private String[] nombre = new String[10];
        private String[] telefono = new String[10];
        private String[] correo = new String[10];
        private String[] domicilio = new String[10];


        public String[] Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public String[] Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public String[] Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String[] Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String[] Id
        {
            get { return id; }
            set { id = value; }
        }

        public ArrayList Registros
        {
            get { return registros; }
            set { registros = value; }
        }            

        public int B4
        {
            get { return b4; }
            set { b4 = value; }
        }

        public int B3
        {
            get { return b3; }
            set { b3 = value; }
        }

        public int B2
        {
            get { return b2; }
            set { b2 = value; }
        }

        public int B1
        {
            get { return b1; }
            set { b1 = value; }
        }

        public int Op
        {
            get { return op; }
            set { op = value; }
        }

        public void menu()
        {
            do
            {
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("Bienvenido al sistema.");
                Console.WriteLine("Por favor, seleccione una opcion:");
                Console.WriteLine("");
                Console.WriteLine("1) Dar de alta a estudiante.");
                Console.WriteLine("2) Dar de baja a estudiante.");
                Console.WriteLine("3) Editar datos.");
                Console.WriteLine("4) Consultar datos.");
                Console.WriteLine("5) Salir.");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: b1 = 1; x = 1;
                        alta();
                        af++;               
                        break;
                    case 2: b1 = 1; x = 1;
                        baja();
                        break;
                    case 3: b1 = 1; x = 1;
                        editar();
                        break;
                    case 4: b1 = 1; x = 1;
                        consulta();
                        break;
                    case 5: b1 = 1; x = 0;
                        Console.WriteLine("");
                        Console.WriteLine("Gracias por utilizar el programa, que tenga buen dia!");
                        Console.ReadKey();
                        break;
                    default: b1 = 1;
                        Console.WriteLine("");
                        Console.WriteLine("No se reconocio la opcion, escribala otra vez.");
                        break;
                }
            } while (b1 != 1);
            } while (x != 0);
        }
        public void alta()
        {
            Console.WriteLine("");
            Console.WriteLine("Escriba su ID:");
            id[af] = Console.ReadLine();
            Console.WriteLine("Escriba el Nombre: ");
            nombre[af] = Console.ReadLine();
            Console.WriteLine("Escriba el Telefono: ");
            telefono[af] = Console.ReadLine();
            Console.WriteLine("Escriba el Correo Electronico: ");
            correo[af] = Console.ReadLine();
            Console.WriteLine("Escriba el Domicilio: ");
            domicilio[af] = Console.ReadLine();
            try
            {
                using (FileStream fs = new FileStream(@"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt", FileMode.Open, FileAccess.ReadWrite))
                {
                    StreamReader sr = new StreamReader(fs);
                    StreamWriter sw = new StreamWriter(fs);

                    string temp = sr.ReadToEnd();
                    fs.Seek(0, SeekOrigin.Begin);
                    sw.Write(temp);
                    sw.WriteLine(id[af] + ";" + nombre[af] + ";" + telefono[af] + ";" + correo[af] + ";" + domicilio[af] + ";");
                    sw.Close();
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Datos dados de Alta.");
                Console.ReadKey();
            }
        }
        public void baja()
        {
            string idsel;
            try
            {
                string ru = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt";
                Console.WriteLine("");
                Console.WriteLine("Escriba el ID del registro a eliminar:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Lista de matriculas en la base de datos:");
                Console.WriteLine("");
                //
                try
                {
                    StreamReader lector2 = new StreamReader(ru);
                    string line = lector2.ReadLine();
                    while (line != null)
                    {
                        string[] id = line.Split(';');
                        string a1 = id[0];
                        Console.WriteLine("-" + a1);
                        line = lector2.ReadLine();
                    }
                    lector2.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error: " + e);
                }
                Console.WriteLine("");
                idsel = Console.ReadLine();
                try
                {
                    StreamReader srsr = new StreamReader(ru);
                    string lin3a = srsr.ReadLine();
                    while (lin3a != null)
                    {
                        string[] dat0s = lin3a.Split(';');
                        string a = dat0s[0];
                        string b = dat0s[1];
                        string c = dat0s[2];
                        string d = dat0s[3];
                        string e = dat0s[4];
                        lin3a = srsr.ReadLine();
                        if (idsel.Equals(a))
                        {
                            try
                            {
                                srsr.Close();
                                string rrt = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxttemp.txt";
                                string rur = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt";
                                StreamReader sf = new StreamReader(rur);
                                string l1n3 = sf.ReadLine();
                                while (l1n3 != null)
                                {
                                    string[] l1 = l1n3.Split(';');
                                    string ad = l1[0];
                                    if (ad != idsel)
                                    {
                                        try
                                        {
                                            StreamWriter srss = new StreamWriter(rrt);
                                            srss.WriteLine(l1n3);
                                            srss.Close();
                                        }
                                        catch (Exception ew)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Error: " + ew);
                                        }
                                    }
                                    l1n3 = sf.ReadLine();
                                }
                                sf.Close();
                                File.Delete(@"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt");
                                File.Move(@"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxttemp.txt", @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt");
                            }
                            catch(Exception ef)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Error: "+ef);
                            }
                        }
                    }
                }
                catch (Exception eee)
                {
                    Console.WriteLine("Error: " + eee);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Accion Finalizada.");
            }
        }
        public void editar()
        {
            try
            {
                string nnombre, ntel, nemail, ndomi, idbu;
                string ruta = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt";
                StreamReader sr = new StreamReader(ruta);
                Console.WriteLine("");
                Console.WriteLine("Ingrese el ID del registro que desea modificar: ");
                Console.WriteLine("Matriculas registradas:");
                Console.WriteLine("");
                try
                {
                    string ruta2 = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt";
                    StreamReader lector2 = new StreamReader(ruta2);
                    string line = lector2.ReadLine();
                    while (line != null)
                    {
                        string[] ids = line.Split(';');
                        string a1 = ids[0];
                        Console.WriteLine("-" + a1);
                        line = lector2.ReadLine();
                    }
                    lector2.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error: " + e);
                }
                Console.WriteLine("");
                idbu = Console.ReadLine();
                StreamReader lector = new StreamReader(ruta);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] reg = linea.Split(';');
                    string a = reg[0];
                    string b = reg[1];
                    string c = reg[2];
                    string d = reg[3];
                    string e = reg[4];
                    if (a.Trim().Equals(idbu))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el nuevo nombre:");
                        nnombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo telefono:");
                        ntel = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo correo:");
                        nemail = Console.ReadLine();
                        Console.WriteLine("Ingrese el nuevo domicilio:");
                        ndomi = Console.ReadLine();
                        string bb = nnombre;
                        string cc = ntel;
                        string dd = nemail;
                        string ee = ndomi;
                        Console.WriteLine("");
                        Console.WriteLine("Antiguos datos:");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("ID: " + a.Trim());
                        Console.WriteLine("Nombre: " + b.Trim());
                        Console.WriteLine("Telefono: " + c.Trim());
                        Console.WriteLine("Correo Electronico: " + d.Trim());
                        Console.WriteLine("Domicilio: " + e.Trim());
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Nuevos datos:");
                        Console.WriteLine("Nombre: " + bb);
                        Console.WriteLine("Telefono: " + cc);
                        Console.WriteLine("Correo Electronico: " + dd);
                        Console.WriteLine("Domicilio: " + ee);
                        Console.WriteLine("-----------------------------------------");
                        try
                        {
                            string rutat = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxtemped.txt";
                                StreamWriter swt = new StreamWriter(rutat);
                                swt.WriteLine(a + ';' + bb + ';' + cc + ';' + dd + ';' + ee);
                                swt.Close();
                                File.Delete(@"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt");
                                File.Move(@"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxttemped.txt", @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt");
                        }
                        catch(Exception ewe)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Error: "+ewe);
                        }
                    }
                    linea = lector.ReadLine();
                }
                lector.Close();
            }
            catch(Exception ec)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: "+ec);
            }
        }
        public void consulta()
        {
            string idbuscado;
            try {
                string ruta = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt";
                Console.WriteLine("Ingrese el ID del registro que desea ver: ");
                Console.WriteLine("Matriculas registradas:");
                Console.WriteLine("");
                //
                try
                {
                    string ruta2 = @"\Users\MarioAlejandro\Desktop\Programas C#\Proyecto_at\atxt.txt";
                    StreamReader lector2 = new StreamReader(ruta2);
                    string line = lector2.ReadLine();
                    while (line != null)
                    {
                        string[] id = line.Split(';');
                        string a1 = id[0];
                        Console.WriteLine("-" + a1);
                        line = lector2.ReadLine();
                    }
                    lector2.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Error: "+e);
                }
                Console.WriteLine("");
                //
                idbuscado = Console.ReadLine();
                StreamReader lector = new StreamReader(ruta);
                string linea = lector.ReadLine();
                while (linea != null)
                {
                    string[] reg = linea.Split(';');
                    string a = reg[0];
                    string b = reg[1];
                    string c = reg[2];
                    string d = reg[3];
                    string e = reg[4];
                        if (a.Trim().Equals(idbuscado))
                        {
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("ID: " + a.Trim());
                            Console.WriteLine("Nombre: " + b.Trim());
                            Console.WriteLine("Telefono: " + c.Trim());
                            Console.WriteLine("Correo Electronico: " + d.Trim());
                            Console.WriteLine("Domicilio: " + e.Trim());
                    }
                    linea = lector.ReadLine();
                }
                lector.Close();
            }
            catch(Exception ed)
            {
                Console.WriteLine("");
                Console.WriteLine("Error: "+ed);
            }
            finally {
                Console.WriteLine("");
                Console.WriteLine("Accion Finalizada.");
                Console.ReadKey();
            }

        }

        ~Elementos()
        {

        }
    }
}
