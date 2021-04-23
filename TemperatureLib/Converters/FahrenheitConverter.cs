using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converters
{
    public class FahrenheitConverter : ITemperatureConverter
    {
        public double FromUnitToCelsius(double input)
        {
            return (input - 32) * 5 / 9;
        }

        public double FromCelsiusToUnit(double input)
        {
            double foo = (input * 9 / 5) + 32;
            return foo;
        }
    }
}
