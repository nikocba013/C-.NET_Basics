using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Where
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matris = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //double media = matris.Where(num => num % 2 == 1).Average();
            List<int> lista1 = new List<int>();

            foreach (int i in matris.Where(y =>
             {
                 if (y % 2 == 1)
                 {
                     //lista1.Add(y);
                     return true;
                 }
                 else
                     return false;

             }
            ))
            { lista1.Add(i); }

                 //lista1.Distinct();
            foreach(var e in lista1)
                {
                    Console.WriteLine(e);
                }
            
            
           // Console.WriteLine(media);
            Console.ReadKey();
        }
    }
}
