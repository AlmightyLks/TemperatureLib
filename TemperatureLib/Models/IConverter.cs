using System;

namespace TemperatureLib.Models
{
    public interface IConverter
    {
        Func<decimal, decimal> GetConversionFunc(TemparatureUnit toUnit);
    }
}
