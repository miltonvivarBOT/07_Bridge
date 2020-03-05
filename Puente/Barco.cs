using PatronPuente.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPuente.Puente
{
    class Barco : IProcesadorEnvios
    {
        public void EntregarPedido()
        {
            Console.WriteLine("  Paquete descargado del Barco");
        }

        public void EnviarPedido()
        {
            Console.WriteLine("  Paquete enviado por Mar");
        }

        public void RecogerPedido()
        {
            Console.WriteLine("  Paquete cargado al Barco");
        }
    }
}
