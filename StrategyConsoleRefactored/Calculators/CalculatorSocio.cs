using System;
using TallerOop.StrategyCommons;

namespace TallerOop.StrategyConsoleRefactored.Calculators
{
    public class CalculatorSocio : ICalculator
    {
        public void SetPrecio(Paquete paq)
        {
            paq.Precio = paq.Alto + 1;
        }
    }
}