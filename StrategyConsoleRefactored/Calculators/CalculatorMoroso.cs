using System;
using TallerOop.StrategyCommons;

namespace TallerOop.StrategyConsoleRefactored.Calculators
{
    public class CalculatorMoroso : ICalculator
    {
        public void SetPrecio(Paquete paq)
        {
            paq.Precio = -1;
        }
    }
}