using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converters
{
    public class KelvinConverter : ITemperatureConverter
    {
        public decimal FromUnitToCelsius(decimal input)
        {
            return input - 273.15M;
        }

        public decimal FromCelsiusToUnit(decimal input)
        {
            return input + 273.15M;
        }
    }
}
