using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandDemo.Models
{
    public class EliminarComando : OrdenarComando
    {
        public override void Ejecutar(List<MenuElemento> orden, MenuElemento menuElemento)
        {
            orden.Remove(orden.FirstOrDefault(x => x.Nombre == menuElemento.Nombre));
        }
    }
}
