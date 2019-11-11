using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar;

namespace Proyecto_Bar
{
    class Program
    {
        //public static int cliente_nro = 0;
        static void Main(string[] args)
        {
            int opcion=0;
            int mesa_nro;
            bool satisfecho = false;
            int prod_elegido;

            Mesa mesa1 = new Mesa(1);
            Mesa mesa2 = new Mesa(2);
            Mesa mesa3 = new Mesa(3);
            Mesa mesa4 = new Mesa(4);

            List<Mesa> mesas1 = new List<Mesa>();
            List<Mesa> mesas2 = new List<Mesa>();

            mesas1.Add(mesa1);
            mesas1.Add(mesa2);
            mesas2.Add(mesa3);
            mesas2.Add(mesa4);

            Mesero mesero1 = new Mesero("Carlos", "Perez", mesas1);
            Mesero mesero2 = new Mesero("Pedro", "Gari", mesas2);

            Producto prod1 = new Producto("Plato1", 45.50, 1);
            Producto prod2 = new Producto("Plato2",70.80,2);
            Producto prod3 = new Producto("Bebida1",25,3);
            Producto prod4 = new Producto("Bebida2",50,4);

            List<Producto> productos = new List<Producto>();
            productos.Add(prod1);
            productos.Add(prod2);
            productos.Add(prod3);
            productos.Add(prod4);

            Carta carta = new Carta(productos);
            // Cliente cliente = new Cliente();

            //do
            //{
            //    Console.WriteLine("En que modo desea ingresar? \n 1- Supervisor \n 2- Cliente");
            //    opcion = Convert.ToInt32(Console.ReadLine());
            //} while (opcion != 1 && opcion != 2);
            ingreso();

            if (opcion == 2)
            {
                Cliente cliente = new Cliente();
                Mesero mesero = new Mesero();   
                 

                BienvenidaAtender(mesero,cliente);
                //Console.WriteLine(cliente.nombre+cliente.cuenta);

                while (satisfecho == false)
                {
                    Console.WriteLine("Desea algo mas?\n-1 Si\n-2 No");
                    if (Convert.ToInt32(Console.ReadLine()) == 2)
                    {
                        satisfecho = true;
                    }
                    else
                    {
                        segundaOrden(mesero, cliente);
                    }

                }
                Console.WriteLine("La cuenta es de: {0}", cliente.cuenta);
                //Console.ReadKey();
                ingreso();
            }
            else if(opcion == 1)
            {

                Console.WriteLine("La billetera de los meseros cuenta con: \n");
                Console.WriteLine(mesero1.ToString());
                Console.WriteLine(mesero2.ToString());
                Console.ReadKey();

            }
            else
            {
                Environment.Exit(0);
            }           
            

            void BienvenidaAtender(Mesero mesero, Cliente cliente)
            {
                //Cliente cliente = new Cliente();
                string nombre;
                Console.WriteLine("Ingresa tu nombre por favor:");
                nombre = Console.ReadLine();
                do
                {
                    Console.WriteLine("Buenos dias {0}, elija una mesa: \n-1\n-2\n-3\n-4",nombre);
                    mesa_nro = Convert.ToInt32(Console.ReadLine());
                } while (mesa_nro > 4 || mesa_nro < 1);

                Mesa mesa_c = new Mesa(mesa_nro);
                foreach (Mesa item in mesero1.mesas)
                {
                    if (item.numero == mesa_c.numero)
                    {
                        mesero = mesero1;
                        cliente.mesa = item;
                        cliente.nombre = nombre;
                    }
                }
                foreach (Mesa item in mesero2.mesas)
                {
                    if (item.numero == mesa_c.numero)
                    {
                        mesero = mesero2;                        
                        cliente.mesa = item;
                        cliente.nombre = nombre;
                    }
                }

                Console.WriteLine("Mi nombre es {0}, sere quien lo atienda hoy, que desea consumir?", mesero.nombre);

                Console.WriteLine(Environment.NewLine + carta.ToString());
                prod_elegido = Convert.ToInt32(Console.ReadLine());
                while (prod_elegido > 4 && prod_elegido < 0)
                {
                    Console.WriteLine(Environment.NewLine + carta.ToString());
                    prod_elegido = Convert.ToInt32(Console.ReadLine());
                }
                foreach (Producto item in productos)
                {
                    if (item.id == prod_elegido)
                    {
                        cliente.cuenta += item.precio;
                        
                    }
                }
            }

            void ingreso()
            {
                do
                {
                    Console.WriteLine("En que modo desea ingresar? \n 1- Supervisor \n 2- Cliente\n 3-Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                } while (opcion != 1 && opcion != 2 && opcion!= 3);
            }

            void segundaOrden(Mesero mesero, Cliente cliente)
            {
                Console.WriteLine(Environment.NewLine + carta.ToString());
                prod_elegido = Convert.ToInt32(Console.ReadLine());
                while (prod_elegido > 4 && prod_elegido < 0)
                {
                    Console.WriteLine(Environment.NewLine + carta.ToString());
                    prod_elegido = Convert.ToInt32(Console.ReadLine());
                }
                foreach (Producto item in productos)
                {
                    if (item.id == prod_elegido)
                    {
                        cliente.cuenta += item.precio;

                    }
                }

            }

        }

        

       
    }
}
