using System.Collections.Generic;
using TemperatureLib.Converters;
using TemperatureLib.Models;

namespace TemperatureLib.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<TemparatureUnit, ITemperatureConverter> temperatureConverters = new Dictionary<TemparatureUnit, ITemperatureConverter>();
            temperatureConverters.Add(TemparatureUnit.Celsius, new CelsiusConverter());
            temperatureConverters.Add(TemparatureUnit.Fahrenheit, new FahrenheitConverter());
            temperatureConverters.Add(TemparatureUnit.Kelvin, new KelvinConverter());
            Converter converter = new Converter(temperatureConverters);
            // ----------------------------------------------------------------

            double celsiusTemperature = 10.0d;

            double celsiusToFahrenheit = converter.Convert(TemparatureUnit.Celsius, celsiusTemperature, TemparatureUnit.Fahrenheit);

            // ----------------------------------------------------------------

            double fahrenheitTemperature = 10.0d;

            double fahrenheitToCelsius = converter.Convert(TemparatureUnit.Fahrenheit, fahrenheitTemperature, TemparatureUnit.Celsius);

            // ----------------------------------------------------------------

            double kelvinTemperature = 10.0d;

            double kelvinToFahrenheit = converter.Convert(TemparatureUnit.Kelvin, kelvinTemperature, TemparatureUnit.Fahrenheit);
        }
    }
}
