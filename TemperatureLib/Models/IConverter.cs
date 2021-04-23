using System;

namespace TemperatureLib.Models
{
    public interface IConverter
    {
        double Convert(TemparatureUnit fromUnit, double input, TemparatureUnit toUnit);
    }
}
