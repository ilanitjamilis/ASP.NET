using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    public class Persona
    {

        //Constructor
        //Metodo que genera un objeto de la clase. En este caso tambien asigna propiedades
        public Persona(string nombreNuevo, string apellidoNuevo, int edadNueva, string sexoNuevo)
        {
            this.nombre = nombreNuevo;
            this.apellido = apellidoNuevo;
            this.edad = edadNueva;
            this.sexo = sexoNuevo;

        }

  

      
        public override string ToString()
        {
           // return nombre;
           return String.Concat(nombre," ",apellido,"-",edad,"-",GetSexo()); //si quiero concatenar varias propiedades
        }


        private string nombre;


        //Metodo publico que devuelve el valor de la propiedad privada nombre
        public string GetNombre() 
        {
            return nombre;
        }


        private string sexo;

        
        public string GetSexo()
        {
            if (sexo=="Masculino")
            {
                return "Masculino";
            }
            else
            {
                return "Femenino";
            }
            

        }


        //Metodo que modifica el valor de la propiedad sexo
        public void CambioSexo()
        {
            if (sexo=="Masculino")
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "Masculino";
            }
            
        }

        private string apellido;

    
        public string GetApellido()
        {
            return apellido;
        }

        private int edad;

        public int GetEdad()
        {
              return edad;
        }

        public void CrecioUnAño()
        {
            edad++;
        }


    }
}
