using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda1
{
    class Program
    {
        delegate int delegado(int i);
        static void Main(string[] args)
        {
            /*
            delegado miDelegado = y => y * y;
            int j = miDelegado(5);
            Console.WriteLine(j);
            Console.ReadKey();
            */
            /*
            int[] numeros = { 1, 2, 3, 5, 6, 10, 23, 42, 322, 45 };
            double media = numeros.Where(y => y % 2 != 0).Average();
            Console.WriteLine(media);
            Console.ReadKey();
            */

            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int i in numeros.Where(x =>
             {
                 if (x <= 3)
                     return true;
                 else if (x >= 7)
                     return true;
                 return false;

             } //LOS CORCHETES SON CUANDO UNA EXP LAMBDA TIENE MAS DE UNA LINEA.
               // LOS QUE CUMPLEN CON LA CONDICION DE LA EXPRESION SE HACE UN WRITELINE.
            ))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

        }
    }
}
