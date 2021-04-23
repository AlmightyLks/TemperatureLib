using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converters
{
    public class CelsiusConverter : ITemperatureConverter
    {
        public double FromCelsiusToUnit(double input)
        {
            return input;
        }

        public double FromUnitToCelsius(double input)
        {
            return input;
        }
    }
}
