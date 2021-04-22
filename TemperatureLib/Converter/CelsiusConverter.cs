using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converter
{
    public class CelsiusConverter : IConverter
    {
        public Func<decimal, decimal> GetConversionFunc(TemparatureUnit toUnit)
        {
            Func<decimal, decimal> result = null;
            switch (toUnit)
            {
                case TemparatureUnit.Celsius:
                    result = (input) => { return input; };
                    break;
                case TemparatureUnit.Fahrenheit:
                    result = (input) => { return (input * 9 / 5) + 32; };
                    break;
                default:
                    throw new NotImplementedException($"Conversion not implemented for unit \"{toUnit}\"");
            }
            return result;
        }
    }
}
