using PatronPuente.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPuente.Puente
{
    class Fedex
    {
        private readonly IProcesadorEnvios procesadorEnvios;

        public Fedex(IProcesadorEnvios procesadorEnvios)
        {
            this.procesadorEnvios = procesadorEnvios;
        }

        public void ProcesaEnvio()
        {
            Console.WriteLine("Fedex procesando pedido...");
            this.procesadorEnvios.RecogerPedido();
            this.procesadorEnvios.EnviarPedido();
            this.procesadorEnvios.EntregarPedido();
        }
    }
}
