using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.Models
{
    public class AgregarComando : OrdenarComando
    {
        public override void Ejecutar(List<MenuElemento> orden, MenuElemento menuElemento)
        {
            orden.Add(menuElemento);
        }
    }
}
