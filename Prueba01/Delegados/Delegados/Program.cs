using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int numeros(int n);

namespace Delegados
{
    class Program
    {
        static int numero = 10;

        public static int sumarNumeros(int p)
        {
            numero += p;
            return numero;
        }

        public static int multiplicarNumeros(int p)
        {
            numero *= p;
            return numero;
        }

        public static int obtenerNumero()
        {
            return numero;
        }

        static void Main(string[] args)
        {
            numeros numero1 = new numeros(sumarNumeros);
            numeros numero2 = new numeros(multiplicarNumeros);
            numeros num;

            num = numero1;
            num += numero2; //ESTO HACE QUE SE EJECUTEN UNO ATRAS DEL OTRO LOS METODOS.

            num(5); //DEBERIA DAR EL RESULTADO DEL PRIMER METODO MAS EL RESULT DEL SEGUNDO.

            Console.WriteLine("El resultado de un delegado anidado es: " + obtenerNumero());
            //numero1(10);
            //Console.WriteLine("El valor de la instancia numero1 es: " + obtenerNumero());

            //numero2(5);
            //Console.WriteLine("El valor de la instancia numero2 es :" + obtenerNumero());

            Console.ReadKey();
        }
    }
}
