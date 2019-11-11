using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    
        public delegate void MiDelegado();
        public delegate int DelegadoInt(int a, int b);


    class Program
    {
        static void Main(string[] args)
        {
                    
            Program c = new Program();
            MiDelegado del = new MiDelegado(c.DecirHolis);
            DelegadoInt deli = new DelegadoInt(c.bla);

            del();
            Console.WriteLine(deli(10, 15));
            
            Console.ReadKey();
        }

        public void DecirHolis()
        {
            Console.WriteLine("holis");
        }

        public int bla(int a, int b)
        {
            int res = a * b;
            return res;
        }


    }         

        
    
}
