using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repaso
{
    class Funciones
    {
        public static bool esNumerico (string texto)
        {
            bool esNumero = true;
            string caracter = "";

            while (texto.Length > 1 && esNumero)
            {
                caracter = texto.Substring(texto.Length - 1, 1);
                if (caracter != "1" && caracter != "2" && caracter != "3" && caracter != "4" && caracter != "5" && caracter != "6" && caracter != "7" && caracter != "8" && caracter != "9" && caracter != "0")
                {
                    esNumero = false;
                }
                else
                {
                    texto = texto.Substring(0, texto.Length - 1);
                }
            }
            if (esNumero && texto.Length == 1)
            {
                caracter = texto;
                if (caracter != "1" && caracter != "2" && caracter != "3" && caracter != "4" && caracter != "5" && caracter != "6" && caracter != "7" && caracter != "8" && caracter != "9" && caracter != "0")
                {
                    esNumero = false;
                }
            }

            return esNumero;
        }

        public static bool aprobo (int n1, int n2, int n3)
        {
            bool almunoAprobado = false;
            int promedio = n1 + n2 + n3;

            if (n3 >= 6 && promedio >= 18)
            {
                almunoAprobado = true;
            }

            return almunoAprobado;
        }





    }
}
;