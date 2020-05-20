using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.Models
{
    public class ListaComida
    {
        public List<MenuElemento> productos { set; get; }

        public ListaComida()
        {
            productos = new List<MenuElemento>();
        }

        public void MostrarProductos()
        {
            foreach(var item in productos)
            {
                item.Desplegar();
            }
            Console.WriteLine("--------------------------");
        }

        public void EjecutarComando(OrdenarComando comando, MenuElemento elemento) 
        {
            comando.Ejecutar(productos, elemento);
        }
    }
}
