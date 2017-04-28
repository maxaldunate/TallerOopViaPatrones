using System;

namespace TallerOop.StrategyCommons
{
    public class Cliente
    {
        public Cliente(string nif, string nombre, bool esGranCuenta, bool esMoroso, bool esSocio)
        {
            Nif = nif;
            Nombre = nombre;
            EsGranCuenta = esGranCuenta;
            EsMoroso = esMoroso;
            EsSocio = esSocio;
        }

        public string Nif { set; get; }
        public string Nombre { set; get; }
        public bool EsGranCuenta { set; get; }
        public bool EsMoroso { set; get; }
        public bool EsSocio { set; get; }
    }
}