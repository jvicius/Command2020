using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.Models
{
    public class Cliente
    {
        private OrdenarComando ordenarComando;
        private MenuElemento menuElemento;
        private ListaComida pedido;

        public Cliente()
        {
            pedido = new ListaComida();
        }

        public void SeleccionarElemento(MenuElemento elemento)
        {
            menuElemento = elemento;
        }

        public void ObtenerComando(int opcion)
        {
            ordenarComando = FabricaComando.ObtenerComando(opcion);
        }

        public void EjecutarComando()
        {
            pedido.EjecutarComando(ordenarComando, menuElemento);
        }

        public void PedidoActual()
        {
            pedido.MostrarProductos();
        }
    }
}
