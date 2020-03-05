using PatronPuente.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPuente.Puente
{
    class Avion : IProcesadorEnvios
    {
        public void EntregarPedido()
        {
            Console.WriteLine("  Paquete descargado del Avión");
        }

        public void EnviarPedido()
        {
            Console.WriteLine("  Paquete enviado por Aire");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("  Paquete cargado al Avión");
        }
    }
}
