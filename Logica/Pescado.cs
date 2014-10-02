using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina.Logica
{
    class Pescado:Plato
    {
        public override void servir()
        {
            Console.WriteLine("Servir plato de pescado");
        }

        public override void cocinar()
        {
            Console.WriteLine("Cocinar plato de pescado");
        }
    }
}
