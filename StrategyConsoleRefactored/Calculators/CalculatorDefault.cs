using System;
using TallerOop.StrategyCommons;

namespace TallerOop.StrategyConsoleRefactored.Calculators
{
    public class CalculatorDefault : ICalculator
    {
        public void SetPrecio(Paquete paq)
        {
            paq.Precio = paq.Alto * paq.Peso;
        }
    }
}