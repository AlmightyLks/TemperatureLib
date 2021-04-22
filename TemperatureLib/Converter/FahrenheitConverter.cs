using System;
using TemperatureLib.Models;

namespace TemperatureLib.Converter
{
    public class FahrenheitConverter : IConverter
    {
        public Func<decimal, decimal> GetConversionFunc(TemparatureUnit toUnit)
        {
            Func<decimal, decimal> result = null;
            switch (toUnit)
            {
                case TemparatureUnit.Celsius:
                    result = (input) => { return (input - 32) * 5 / 9; };
                    break;
                case TemparatureUnit.Fahrenheit:
                    result = (input) => { return input; };
                    break;
                default:
                    throw new NotImplementedException($"Conversion not implemented for unit \"{toUnit}\"");
            }
            return result;
        }
    }
}
