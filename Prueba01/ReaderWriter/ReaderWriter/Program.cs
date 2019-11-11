using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReaderWriter
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] nombres = new string[] { "Lalo", "Nico" };
            using (StreamWriter escribir = new StreamWriter("D:/prueba.txt"))
            {
                foreach (string nombre in nombres)
                {
                    escribir.WriteLine(nombre);
                }

            }
            string linea;
            // LOS USING ES PARA QUE EL ARCHIVO SE CIERRE DESPUES DE USARSE.
            using(StreamReader leer = new StreamReader("D:/prueba.txt"))
            {
                while ( (linea = leer.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                }                
            }
            Console.ReadKey();
        }
    }
}
