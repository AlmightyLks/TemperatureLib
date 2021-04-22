using System;

namespace TemperatureLib.Models
{
    public interface IConverter
    {
        decimal ConvertToUnit(TemparatureUnit toUnit, decimal input);
        decimal ConvertToCelsius(TemparatureUnit fromUnit, decimal input);
    }
}
