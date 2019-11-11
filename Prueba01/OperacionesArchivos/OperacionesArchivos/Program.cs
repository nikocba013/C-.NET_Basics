using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesArchivos
{
    class Program
    {
        static void Main(string[] args)
        {

            

                if(File.Exists("bla.txt"))
            {
                string contenido = File.ReadAllText("bla.txt");
                Console.WriteLine("El contenido es :\n" + contenido);
                Console.WriteLine("Ingrese el nuevo contenido");
            }
            else
            {
                Console.WriteLine("Ingrese el contenido del archivo: ");
            }


                string contenido2 = Console.ReadLine();

                File.WriteAllText("bla.txt", contenido2);
                string contenido3 = File.ReadAllText("bla.txt");
                Console.Write("El contenido del archivo es: \n" + contenido3);
                Console.ReadKey();
            
        }
    }
}
