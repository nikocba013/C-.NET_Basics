using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            int res, n1, n2;
            Console.WriteLine("Numero1");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero2");
            n2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                res = n1 / n2;
                Console.WriteLine("Resultado:" + res);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }


        }
    }
}
