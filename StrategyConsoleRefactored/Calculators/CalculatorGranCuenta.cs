using System;
using TallerOop.StrategyCommons;

namespace TallerOop.StrategyConsoleRefactored.Calculators
{
    public class CalculatorGranCuenta : ICalculator
    {
        public void SetPrecio(Paquete paq)
        {
            paq.Precio = paq.Alto + paq.Peso;
        }
    }
}