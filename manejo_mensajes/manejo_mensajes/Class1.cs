using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manejo_mensajes{

    class Class1{
        private string texto;

        public string texto{

        set { 
                    texto = value; 
                }
        get { 
                    return texto; 
                }   
        }
public void MensajeUsuario(){
Console.Clear();
Console.writeLine("El mensaje es: "+ this.texto);

}
    }
        }
    }
}
