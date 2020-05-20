using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.Models
{
    public abstract class OrdenarComando
    {
        public abstract void Ejecutar(List<MenuElemento> orden, MenuElemento menuElemento);
    }
}
