using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesII
{

    public interface IOrganismo
    {
        void respirar();


        void mover();
       
    }

    public interface IAnimal
    {
        void mover();

        void viviparo();
    }

    class Perro : IOrganismo, IAnimal
    {
        public void respirar()
        {
            Console.WriteLine("Respirar");
        }

         void IOrganismo.mover()
        {
            Console.WriteLine("Mover Organismo");
        }

        void IAnimal.mover()
        {
            Console.WriteLine("Mover Animal");
        }

        public void viviparo()
        {
            Console.WriteLine("Viviparo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perro perros = new Perro();
            IAnimal animal = perros;
            IOrganismo organismo = perros;

            perros.respirar();
            perros.viviparo();

            animal.mover();
            organismo.mover();

            Console.ReadKey();
        }
    }
}
