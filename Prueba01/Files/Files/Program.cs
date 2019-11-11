using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream f = new FileStream("C:/Users/nferreyra/Desktop/Proyect/C#/Curso_C#/Prueba01/Files/prueba.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            string a = "hola ";
            for (int i = 1; i <= 10; i++)
            {
                f.WriteByte((byte)i);                
            }

            f.Position = 0;
            for (int i = 0; i < f.Length; i++)
            {
                Console.Write(f.ReadByte() + " ");
            }

            Console.ReadKey();



        }
    }
}
