using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Aula
    {
        public string codigo { get; set; }
        public int capacidad { get; set; }

        public Aula(int capacidad, string codigo)
        {
            this.codigo = codigo;
            this.capacidad = capacidad;
        }
    }
}
