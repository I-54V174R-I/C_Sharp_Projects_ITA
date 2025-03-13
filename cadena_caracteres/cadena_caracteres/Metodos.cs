using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cadena_caracteres
{

    class Metodos
    {
        public static int[] cantPalabras(string frase)
        {
            int p = 1;
            int v = 0;
            int con = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'A' || frase[i] == 'e' || frase[i] == 'E' || frase[i] == 'i' || frase[i] == 'I' || frase[i] == 'o' || frase[i] == 'O' || frase[i] == 'u' || frase[i] == 'U')
                {
                    v++;
                }
                if (frase[i] == ' ' || frase[i] == '.')
                {
                    p++;
                }
                switch (frase[i])
                {
                    case 'b': con++;
                        break;
                    case 'c': con++;
                        break;
                    case 'd': con++;
                        break;
                    case 'f': con++;
                        break;
                    case 'g': con++;
                        break;
                    case 'h': con++;
                        break;
                    case 'j': con++;
                        break;
                    case 'k': con++;
                        break;
                    case 'l': con++;
                        break;
                    case 'm': con++;
                        break;
                    case 'n': con++;
                        break;
                    case 'ñ': con++;
                        break;
                    case 'p': con++;
                        break;
                    case 'q': con++;
                        break;
                    case 'r': con++;
                        break;
                    case 's': con++;
                        break;
                    case 't': con++;
                        break;
                    case 'v': con++;
                        break;
                    case 'w': con++;
                        break;
                    case 'x': con++;
                        break;
                    case 'y': con++;
                        break;
                    case 'z': con++;
                        break;
                }
                int[] cPal = new int[3];
                cPal[0] = p;
                cPal[1] = v;
                cPal[2] = con;
                return cPal;
            }
        }
    }
}
