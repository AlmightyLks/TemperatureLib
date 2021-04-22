using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converters
{
    public class FahrenheitConverter : ITemperatureConverter
    {
        public decimal FromUnitToCelsius(decimal input)
        {
            return (input - 32) * 5 / 9;
        }

        public decimal FromCelsiusToUnit(decimal input)
        {
            decimal foo = (input * 9 / 5) + 32;
            return foo;
        }
    }
}
