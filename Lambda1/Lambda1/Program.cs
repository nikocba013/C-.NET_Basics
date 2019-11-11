using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda1
{
    class Program
    {
        delegate int Delegado(int a);
        delegate string DelegadoString(string a);
        static void Main(string[] args)
        {
            Delegado a = y => y * y;
            int b = a(5);

            Console.WriteLine(b); //IMPRIME 25
            DelegadoString f = y => y.Substring(2, 3);
            string bla = f("holis");
            Console.WriteLine(bla); //IMPRIME LIS
            Console.ReadKey();
        }
    }
}
