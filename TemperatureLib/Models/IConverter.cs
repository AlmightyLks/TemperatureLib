using System;

namespace TemperatureLib.Models
{
    public interface IConverter
    {
        decimal Convert(TemparatureUnit fromUnit, decimal input, TemparatureUnit toUnit);
    }
}
