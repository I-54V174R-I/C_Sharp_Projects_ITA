using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen
{
    class Elementos
    {
        private double balance = 0, deposito = 0, retiro = 0;
        private String op1;

        public String Op1
        {
            get { return op1; }
            set { op1 = value; }
        }
        private int op, b1, b2, x, cont;

        public int Cont
        {
            get { return cont; }
            set { cont = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
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

        public double Retiro
        {
            get { return retiro; }
            set { retiro = value; }
        }

        public double Deposito
        {
            get { return deposito; }
            set { deposito = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void _deposito() {
            Console.WriteLine("");
            Console.WriteLine("Escriba la cantidad a depositar:");
            Console.WriteLine("Su saldo actual: $" + Balance);
            Deposito = double.Parse(Console.ReadLine());
            Balance = Balance + Deposito;
            Console.WriteLine("");
            Console.WriteLine("Hecho");
            Console.WriteLine("Su saldo despues del movimiento: $" + Balance);
        }
        public void _retiro()
        {
            Console.WriteLine("");
            Console.WriteLine("Escriba la cantidad a retirar:");
            Console.WriteLine("Su saldo actual: $" + Balance);
            Retiro = double.Parse(Console.ReadLine());
            if (Retiro <= Balance)
            {
                Balance = Balance - Retiro;
                Console.WriteLine("");
                Console.WriteLine("Hecho");
                Console.WriteLine("Su saldo despues del movimiento: $" + Balance);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Usted no puede retirar porque no tiene saldo suficiente.");
            }
        }
        ~Elementos() {
            Console.WriteLine("Constructor Destruido.");
        }
    }
}
