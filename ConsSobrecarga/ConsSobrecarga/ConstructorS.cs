using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsSobrecarga
{
    class ConstructorS
    {
        private int op1, op2;
        private String op3, op4;

public String Op4
{
  get { return op4; }
  set { op4 = value; }
}

public String Op3
{
  get { return op3; }
  set { op3 = value; }
} 

        public int Op2
        {
            get { return op2; }
            set { op2 = value; }
        }

        public int Op1
        {
            get { return op1; }
            set { op1 = value; }
        }
        public Clase_constructor(){
            Console.Write("Operador Uno: ");
            this.Op1=Convert.ToInt16(Console.ReadLine());
            Console.Write("Operador Dos: ");
            this.Op2=Convert.ToInt16(Console.ReadLine());
        }
        public Suma(int p1, int p2){
            int suma = p1 + p2;
            Console.Write(suma);
        }
        public void suma(String p1, String p2){
            String suma = p1 + p2;
            Console.Write(suma);
        }
        ~ Clase_constructor(){
            Console.Write("");
            Console.ReadKey();
        }
    }
}
