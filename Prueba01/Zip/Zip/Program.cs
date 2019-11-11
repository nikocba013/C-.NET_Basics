using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace Zip
{
    //SE AGREGAN "REFERNCIAS" SYSTEM.IO.COMPRESSION  Y SYSTEM.IO.COMPRESSION.FILESYSTEM
    class Program
    {
        static void Main(string[] args)
        {
            //Comprimir archivo
            //ZipFile.CreateFromDirectory("D:/temp/Directorio1", "D:/temp/ejemplo02.zip",CompressionLevel.Optimal,false);

            //Descomprimir archivo
            ZipFile.ExtractToDirectory("D:/temp/ejemplo02.zip", "D:/temp/Descomprimir/DirDestino"); 


        }
    }
}
