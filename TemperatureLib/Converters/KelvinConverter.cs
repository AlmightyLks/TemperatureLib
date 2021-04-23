using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converters
{
    public class KelvinConverter : ITemperatureConverter
    {
        public double FromUnitToCelsius(double input)
        {
            return input - 273.15d;
        }

        public double FromCelsiusToUnit(double input)
        {
            return input + 273.15d;
        }
    }
}
