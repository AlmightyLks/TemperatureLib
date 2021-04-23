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
        private Dictionary<TemparatureUnit, ITemperatureConverter> _converters;
        public Converter(IDictionary<TemparatureUnit, ITemperatureConverter> converters)
        {
            _converters = new Dictionary<TemparatureUnit, ITemperatureConverter>(converters);
        }
        public double Convert(TemparatureUnit fromUnit, double input, TemparatureUnit toUnit)
        {
            if (fromUnit == toUnit)
            {
                throw new ArgumentException("Cannot convert to the same temperature.");
            }
            double middleCelsius = _converters[fromUnit].FromUnitToCelsius(input);
            double result = _converters[toUnit].FromCelsiusToUnit(middleCelsius);

            return result;
        }
    }
}
