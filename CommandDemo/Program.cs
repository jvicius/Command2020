using CommandDemo.Models;
using System;

namespace CommandDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente();
            cliente.ObtenerComando(1);//agregar
            cliente.SeleccionarElemento(new MenuElemento ("Papas a la francesa", 2, 70));
            cliente.EjecutarComando();

            cliente.ObtenerComando(1);//agregar
            cliente.SeleccionarElemento(new MenuElemento("Hamburguesa", 1, 80));
            cliente.EjecutarComando();

            cliente.ObtenerComando(1);//agregar
            cliente.SeleccionarElemento(new MenuElemento("Coca", 2, 30));
            cliente.EjecutarComando();

            cliente.PedidoActual();

            cliente.ObtenerComando(3);//eliminar
            cliente.SeleccionarElemento(new MenuElemento("Papas a la francesa", 2, 70));
            cliente.EjecutarComando();

            cliente.PedidoActual();

            cliente.ObtenerComando(2);//modificar
            cliente.SeleccionarElemento(new MenuElemento("Hamburguesa", 4, 320));
            cliente.EjecutarComando();

            cliente.PedidoActual();

        }
    }
}
