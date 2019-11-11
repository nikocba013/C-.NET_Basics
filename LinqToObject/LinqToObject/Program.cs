using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObject
{
    class Colegio
    {
        public int id { get; set; }
        public string nombre { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Colegio> colegios = new List<Colegio>();

            string[] nombres = { "Hola", "Que tal", "Chango" };

            var lista = from n in nombres select n;

            foreach(var i in lista)
            {
                Console.WriteLine(i);
            }

            colegios.Add(new Colegio { id=1, nombre = "Colegio 1" });
            colegios.Add(new Colegio { id = 2, nombre = "Colegio 2" });
            colegios.Add(new Colegio { id = 3, nombre = "Colegio 3 " });

            var coles = from c in colegios select c;

            foreach(var cole in coles)
            {
                Console.WriteLine("El colegio {0}, tiene el nombre {1}", cole.id, cole.nombre);
            }

            Console.ReadKey();
        }
    }
}
