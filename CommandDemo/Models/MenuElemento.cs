using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.Models
{
    public class MenuElemento
    {
        public MenuElemento(string nombre, int cantidad, double precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public string Nombre { set; get; }
        public int Cantidad { set; get; }
        public double Precio { set; get; }

        public void Desplegar()
        {
            Console.WriteLine("");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"Precio ${Precio}");
        }
    }
}
