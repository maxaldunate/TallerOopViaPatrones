using System;
using TallerOop.StrategyCommons;

namespace TallerOop.StrategyConsole
{
    public class CalculoPrecios
    {
        private Cliente _cliente;

        public CalculoPrecios(Cliente cliente)
        {
            _cliente = cliente;
        }

        public void SetPrecio(Paquete paquete)
        {
            if (_cliente.EsMoroso)
                paquete.Precio = -1;
            else if (_cliente.EsSocio)
                paquete.Precio = (paquete.Alto + 1);
            else if (_cliente.EsGranCuenta)
                paquete.Precio = (paquete.Alto + paquete.Peso);
            else
                paquete.Precio = (paquete.Alto * paquete.Peso);
        }

    }
}