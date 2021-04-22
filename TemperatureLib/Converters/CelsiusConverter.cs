using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converters
{
    public class CelsiusConverter : ITemperatureConverter
    {
        public decimal FromCelsiusToUnit(decimal input)
        {
            return input;
        }

        public decimal FromUnitToCelsius(decimal input)
        {
            return input;
        }
    }
}
