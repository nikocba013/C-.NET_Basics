using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{

    class User
    {
        public int id;
        public string nombre;

        public User(int a , string b)
        {
            id = a;

            nombre = b;
        }

        public override string ToString()
        {
            string a = "El usuario : " + nombre + " tiene el id: " + id;
            return a;
        }

    }

    public class ListaGenerica<T>
    {
        private List<T> elemento;

        public ListaGenerica()
        {
            elemento = new List<T>();
        }

        public void Agregar(T nuevo)
        {
            elemento.Add(nuevo);
        }

        public void Eliminar(T nuevo)
        {
            elemento.Remove(nuevo);
        }

        public void Listar()
        {
            foreach (var el in elemento)
            {
                Console.WriteLine("El elemento es: " + el.ToString());
            }
        }
    }


    class Program
    {
        

        static void Main(string[] args)
        {

            ListaGenerica<User> lista = new ListaGenerica<User>();

            lista.Agregar(new User(1, "Nico"));

            lista.Listar();
            

            Console.ReadKey();
        }
    }
}
