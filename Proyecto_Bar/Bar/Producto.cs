﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public class Producto
    {
        public string nombre { get; set; }
        public double precio { get; set; }
        public int id { get; set; }

        public Producto(string nombre, double precio, int id)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.id = id;
        }
    }
}
