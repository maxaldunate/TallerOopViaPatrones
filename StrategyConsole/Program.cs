using System;
using TallerOop.StrategyCommons;

namespace TallerOop.StrategyConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var paq1 = new Paquete(10, 10, 15, 20);
            var cli = new Cliente("NIF1", "Max", true, true, true);

            var gestor = new CalculoPrecios(cli);
            gestor.SetPrecio(paq1);
            Console.WriteLine("Precio Moroso      = " + paq1.Precio);

            cli.EsMoroso = false;
            gestor.SetPrecio(paq1);
            Console.WriteLine("Precio Socio       = " + paq1.Precio);

            cli.EsSocio = false;
            gestor.SetPrecio(paq1);
            Console.WriteLine("Precio Gran Cuenta = " + paq1.Precio);

            cli.EsGranCuenta = false;
            gestor.SetPrecio(paq1);
            Console.WriteLine("Precio General     = " + paq1.Precio);

            Console.ReadKey();
        }
    }
}