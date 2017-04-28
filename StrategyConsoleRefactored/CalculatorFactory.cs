using System;
using TallerOop.StrategyCommons;
using TallerOop.StrategyConsoleRefactored.Calculators;

namespace TallerOop.StrategyConsoleRefactored
{
    public class CalculatorFactory
    {
        public ICalculator GetCalculator(Cliente cli)
        {
            if (cli.EsMoroso)
                return new CalculatorMoroso();
            else if (cli.EsSocio)
                return new CalculatorSocio();
            else if (cli.EsGranCuenta)
                return new CalculatorGranCuenta();
            else
                return new CalculatorDefault();

        }
    }
}