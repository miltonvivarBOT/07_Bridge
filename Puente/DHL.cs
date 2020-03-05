using PatronPuente.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPuente.Puente
{
    class DHL
    {
        private readonly IProcesadorEnvios procesadorEnvios;

        public DHL(IProcesadorEnvios procesadorEnvios)
        {
            this.procesadorEnvios = procesadorEnvios;
        }

        public void ProcesaEnvio()
        {
            Console.WriteLine("DHL procesando pedido...");
            this.procesadorEnvios.RecogerPedido();
            this.procesadorEnvios.EnviarPedido();
            this.procesadorEnvios.EntregarPedido();

        }
    }
}
