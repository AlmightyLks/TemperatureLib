using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureLib.Models;

namespace TemperatureLib.Converters
{
    public class Converter : IConverter
    {
        public Dictionary<TemparatureUnit, ITemperatureConverter> Converters { get; }
        public Converter()
        {
            Converters = new Dictionary<TemparatureUnit, ITemperatureConverter>();
            Converters.Add(TemparatureUnit.Celsius, new CelsiusConverter());
        }
        public decimal Convert(TemparatureUnit fromUnit, decimal input, TemparatureUnit toUnit)
        {
            var middleCelsius = Converters[fromUnit].FromUnitToCelsius(input);
            var result = Converters[toUnit].FromCelsiusToUnit(middleCelsius);

            return result;
        }
    }
}
