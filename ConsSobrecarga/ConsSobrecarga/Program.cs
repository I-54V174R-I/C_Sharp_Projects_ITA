using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstructorS obj = new ConstructorS();
            obj.Suma(obj.Op1, obj.Op2);
            obj.suma(obj.);
        }
    }
}
