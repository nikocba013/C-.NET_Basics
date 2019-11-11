using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Clase
    {
        public DateTime inicio_clase { get; set; }
        public DateTime fin_clase { get; set; }
        public Aula aula { get; set; }

        public Clase (DateTime pIni , DateTime pfin, Aula a)
        {
            inicio_clase = pIni;
            fin_clase = pfin;
            aula = a;
        }
    }
}
