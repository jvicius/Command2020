using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandDemo.Models
{
    public class ModificarComando : OrdenarComando
    {
        public override void Ejecutar(List<MenuElemento> orden, MenuElemento menuElemento)
        {
            var temp = orden.FirstOrDefault(x => x.Nombre == menuElemento.Nombre);
            temp.Precio = menuElemento.Precio;
            temp.Cantidad = menuElemento.Cantidad;
        }
    }
}
