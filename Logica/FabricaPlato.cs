using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina.Logica
{
    class FabricaPlato
    {
        public Plato crearPlato(int tipo)
        {
            Plato plato = null;
            if (tipo == 1)
                plato = new Carne();
            else if (tipo == 2)
                plato = new Chuleta();
            else if (tipo == 3)
                plato = new Pescado();
            else
                Console.WriteLine("No se reconoce el tipo");
            return plato;
        }
        
    }
}
