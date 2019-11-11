using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpresionesLambda2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Expresion lambda creada de manera implicita, creamos una instancia a la expresion
            Func<int, int> expresion1 = x => x + 1;

            //usar la expresion lambda en el cuerpo de la declaracion
            Func<int, int> expresion2 = x => { return x + 1; };

            //usar parametros en la expresion
            Func<int, int> expresion3 = (int x) => x + 1;

            //usar parametros en la expresion para usar en el cuerpo de la declaracion
            Func<int, int> expresion4 = (int x) => { return x + 1; };

            //usar lambda con varios parametros
            Func<int, int, int> expresion5 = (x, y) => x * y;

            //usar lambda en un metodo delegado
            Func<int, int> expresion6 = delegate (int x) { return x + 1; };

            //usar lambda en un metodo delegado sin parametros

            Func<int, int> expresion7 = delegate { return 1 + 1; };


            Console.WriteLine(expresion1.Invoke(1));
            Console.ReadKey();*/

            // USO DE EXP LAMBDA EN COLECCIONES DE LISTAS.
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> pares = numeros.FindAll(x => (x % 2) == 0);

                Console.WriteLine("Los pares son");
            foreach (var p in pares)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();

        }
    }
}
