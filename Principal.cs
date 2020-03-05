using PatronPuente.Interfaces;
using PatronPuente.Puente;
using System;

namespace PatronPuente
{
    class Principal
    {
        static void Main(string[] args)
        {

            IProcesadorEnvios procesadorEnviosAire = new Avion();
            IProcesadorEnvios procesadorEnviosTerrestre = new Tren();
            IProcesadorEnvios procesadorEnviosMar = new Barco();

            DHL paqueteriaDHL = new DHL(procesadorEnviosMar);
            paqueteriaDHL.ProcesaEnvio();
            Console.WriteLine("------------------------------------\n");
            Fedex paqueteriaFedex = new Fedex(procesadorEnviosAire);
            paqueteriaFedex.ProcesaEnvio();
            paqueteriaFedex = new Fedex(procesadorEnviosMar);
            paqueteriaFedex.ProcesaEnvio();
            Console.WriteLine("------------------------------------\n");
            Estafeta paqueteriaEstafeta = new Estafeta(procesadorEnviosTerrestre);
            paqueteriaEstafeta.ProcesaEnvio();
            Console.WriteLine("------------------------------------\n");

        }
    }
}
