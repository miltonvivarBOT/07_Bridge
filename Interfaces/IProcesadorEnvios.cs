using System;
using System.Collections.Generic;
using System.Text;

namespace PatronPuente.Interfaces
{
    interface IProcesadorEnvios
    {
        void RecogerPedido();
        void EnviarPedido();
        void EntregarPedido();

    }
}
