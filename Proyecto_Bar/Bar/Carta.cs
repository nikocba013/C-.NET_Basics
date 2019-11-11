using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public class Carta
    {
        List<Producto> productos;

        public Carta(List<Producto> productos)
        {
            this.productos = productos;
        }

        public override string ToString()
        {
            string carta = "Carta: \n\n";
            foreach(Producto item in productos)
            {
                carta += "-"+item.id+" "+item.nombre+" $"+item.precio+".\n";
            }
            carta += "\n-0 Salir";
            return carta ;
        }

    }
}
