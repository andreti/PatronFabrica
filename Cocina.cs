using Cocina.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cocina
{
    static class Cocina
    {
        static void Main()
        {

            int tipo = Convert.ToInt32(Console.ReadLine());
            FabricaPlato fc = new FabricaPlato();
            Plato plato = fc.crearPlato(tipo);
            plato.cocinar();
            plato.servir();
        }
    }
}
