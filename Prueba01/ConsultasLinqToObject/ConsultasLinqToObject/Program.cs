using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultasLinqToObject
{
    class Program
    {
        class Colegio
        {
            public int id { get; set; }

            public string nombre { get; set; }

            public override string ToString()
            {
                string ab = "Colegio numero: " + id + " Nombre: " + nombre;

                return ab;
            }
        }

        static void Main(string[] args)
        {
            /*Ejemplo para array
             * string [] nombres = { "Nico", "Carlos", "Pedro" };

            var lista = from n in nombres select n;

            foreach(var l in lista)
            {
                Console.WriteLine(l);
            }
            Console.ReadKey();*/

            //Ejemplo con una Clase
            List<Colegio> colegios = new List<Colegio>();

            colegios.Add(new Colegio { id = 1, nombre = "Colegio 1" });
            colegios.Add(new Colegio { id = 2, nombre = "Colegio 2" });
            colegios.Add(new Colegio { id = 3, nombre = "Colegio 3" });

            var colegiosLista = from c in colegios select c;

            foreach (var ob in colegiosLista)
            {
                Console.WriteLine(ob.ToString());
            }
            Console.ReadKey();
        }
    }
}
