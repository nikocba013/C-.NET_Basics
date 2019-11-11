using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Materia
    {
        public string nombre { get; set; }
        public string programa { get; set; }

        public Materia (string nombre ,string prog)
        {
            this.nombre = nombre;
            this.programa = prog;
        }
    }
}
