using PatronPuente.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPuente.Puente
{
    class Tren : IProcesadorEnvios
    {
        public void EntregarPedido()
        {
            Console.WriteLine("  Paquete descargado del Tren");
        }

        public void EnviarPedido()
        {
            Console.WriteLine("  Paquete enviado por Tierra");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("  Paquete cargado al Tren");
        }
    }
}
