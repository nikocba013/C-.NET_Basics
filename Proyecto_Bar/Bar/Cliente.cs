using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public class Cliente:Persona
    {
        public Mesa mesa { get; set; }
        public double cuenta { get; set; }

        public Cliente(Mesa mesa)
        {
            this.mesa = mesa;
            cuenta = 0;
        }

        public Cliente (string nombre, Mesa mesa)
        {
            this.nombre = nombre;
            this.apellido = "Cliente";
            this.mesa = mesa;
            cuenta = 0;
        }

        public Cliente()
        {
            cuenta = 0;
        }

    }

   
}
