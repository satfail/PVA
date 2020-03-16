using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5_POO
{
    class Cliente : Persona
    {
        private String idUser;
        public Cliente(string nombre, string apellido, int edad, string dni, string idUser)
        {
            this.idUser = idUser;
        }

        public Cliente() { }

        public string cIdUser
        {
            get
            {
                return this.idUser;
            }

            set
            {
                this.idUser = value;

            }
        }

    }
}
