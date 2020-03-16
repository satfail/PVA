using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_POO
{
    class Persona
    {

        private String nombre;
  


        private String apellido;
 
        private int edad;

        private String dni;


        public Persona(string nombre, string apellido, int edad, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        public Persona()
        {
        }

        public string pNombre
        {

            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }


        public string pApellido
        {

            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido = value;
            }
        }



        public int pEdad
        {

            get
            {
                return this.edad;
            }

            set
            {
                this.edad = value;
            }
        }


        public string pDni
        {

            get
            {
                return this.dni;
            }

            set
            {
                this.dni = value;
            }
        }



        public int edadtoMes(int edad)
        {

            return edad * 12;
        }

        public override String ToString()
        {
            return this.nombre + " " + this.apellido + " " +
                this.edad + " " + this.dni;
        }

    }
}
