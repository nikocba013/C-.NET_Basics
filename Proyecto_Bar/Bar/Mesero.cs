using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public class Mesero:Persona
    {
        public double propina { get; set; }
        public List<Mesa> mesas { get; set; }
        public double total { get; set; }

        public Mesero(string nombre, string apellido, List<Mesa> mesas)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.mesas = mesas;
            this.propina = 0;
            this.total = 0;
        }

        public Mesero() { }

        public override string ToString()
        {
            string billeteras= "La billeterla del Mesero "+nombre+" contiene: "+total+" sin contar propinas.\n" ;
            return billeteras;
        }

    }

    
}
