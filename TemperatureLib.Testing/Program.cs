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

            Temperature celsiusTemperature = new Temperature(TemparatureUnit.Celsius, converter);
            celsiusTemperature.Value = 10.0d;

            double celsiusToFahrenheit = celsiusTemperature.To(TemparatureUnit.Fahrenheit);

            // ----------------------------------------------------------------

            Temperature fahrenheitTemperature = new Temperature(TemparatureUnit.Fahrenheit, converter);
            fahrenheitTemperature.Value = 10.0d;

            double fahrenheitToCelsius = fahrenheitTemperature.To(TemparatureUnit.Celsius);

            // ----------------------------------------------------------------

            Temperature kelvinTemperature = new Temperature(TemparatureUnit.Kelvin, converter);
            kelvinTemperature.Value = 10.0d;

            double kelvinToFahrenheit = kelvinTemperature.To(TemparatureUnit.Fahrenheit);
        }
    }
}
