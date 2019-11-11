using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Alumno:Persona
    {
        public bool aprobado;

        public Alumno ( string nombre,string apellido, bool aprobado)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.aprobado = aprobado;
        }
    }
}
