using System;

namespace TallerOop.StrategyConsole
{
    public class Paquete
    {
        public Paquete(double peso, double alto, double ancho, double largo)
        {
            Alto = alto;
            Ancho = ancho;
            Largo = largo;
            Peso = peso;
        }

        public double Alto { private set; get; }
        public double Ancho { private set; get; }
        public double Largo { private set; get; }
        public double Peso { private set; get; }

        public double Precio { set; get; }

        public override string ToString()
        {
            return Peso + " Kg. Dim=" + Alto + "x" + Ancho + "x" + Largo + ".";
        }

    }
}