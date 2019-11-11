using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Instructor:Persona
    {
        public List<Materia> materias { get; set; }

            public Instructor (string nombre, string apellido, List<Materia> materias)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.materias = materias;
        }
    }
}
