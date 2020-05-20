using System;
using System.Collections.Generic;
using System.Text;

namespace CommandDemo.Models
{
    public static class FabricaComando
    {
        public static OrdenarComando ObtenerComando(int opcion)
        {
            if (opcion == 1) return new AgregarComando();
            if (opcion == 2) return new ModificarComando();
            if (opcion == 3) return new EliminarComando();
            
            return new AgregarComando();
        }
    }
}
