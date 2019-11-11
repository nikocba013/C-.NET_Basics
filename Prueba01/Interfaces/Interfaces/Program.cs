using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Organismo
    {

        public void respirar()
        {
            Console.WriteLine("Respira");
        }

        public void mover()
        {
            Console.WriteLine("Se mueve");
        }

        public void crecer()
        {
            Console.WriteLine("Crece");
        }

    }

    public interface IAnimales
    {
        void multiCelulares();

        void sangreCaliente();
    }

    public interface IAnimal : IAnimales
    {
        void correr();

        void viviparo();
    }

    public interface IPajaro : IAnimales
    {
        void volar();

        void oviparo();
    }

    class Perro : Organismo, IAnimal
    {
        public void correr()
        {
            Console.WriteLine("Corre");
        }

        public void multiCelulares()
        {
            Console.WriteLine("Es multi celular");
        }

        public void sangreCaliente()
        {
            Console.WriteLine("Tiene Sangre Caliente");
        }

        public void viviparo()
        {
            Console.WriteLine("Es viviparo.");
        }
    }

    class Aguila : Organismo, IPajaro
    {
        public void multiCelulares()
        {
            Console.WriteLine("Es multi celular");
        }

        public void sangreCaliente()
        {
            Console.WriteLine("Tiene Sangre Caliente");

        }

        public void volar()
        {
            Console.WriteLine("Vuela");
        }

        public void oviparo()
        {
            Console.WriteLine("Es oviparo");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Perro prro = new Perro();

            Console.WriteLine("Estas son las caracteristicas de los perros:");
            prro.correr();
            prro.crecer();
            prro.mover();
            prro.respirar();
            prro.viviparo();

            Console.ReadKey();

        }
    }
}
