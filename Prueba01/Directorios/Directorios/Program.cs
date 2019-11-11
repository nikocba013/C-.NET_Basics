using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorios
{
    class Program
    {
        static void Main(string[] args)
        {
            if(File.Exists("prueba.txt"))
            {
                Console.WriteLine("Introduce el nuevo nombre del archivo (sin la extension): ");
                string nom = Console.ReadLine();
                
                if(nom != string.Empty)
                {
                    File.Move("prueba.txt", nom+".txt");
                }
            }
            if(Directory.Exists("folder"))
            {
                Console.WriteLine("Introducir un nuevo nombre para la carpeta: ");
                string fold = Console.ReadLine();
                if(fold != string.Empty)
                {
                    Directory.Move("folder", fold);

                    //Directory.CreateDirectory("path");
                }
                
            }
        }
    }
}
