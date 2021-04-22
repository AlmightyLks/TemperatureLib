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

        public decimal ConvertToUnit(TemparatureUnit toUnit, decimal input)
        {
            return Converters[toUnit].FromCelsiusToUnit(input);
        }

        public decimal ConvertToCelsius(TemparatureUnit fromUnit, decimal input)
        {
            return Converters[fromUnit].FromUnitToCelsius(input);
        }
    }
}
