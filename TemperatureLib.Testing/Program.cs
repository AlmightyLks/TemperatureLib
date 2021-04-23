using TemperatureLib.Converters;
using TemperatureLib.Models;

namespace TemperatureLib.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // A default converter already has a celsius converter due to it being its base unit.
            Converter converter = new Converter();
            // Add a converter for my unit.
            converter.Converters.Add(TemparatureUnit.Fahrenheit, new FahrenheitConverter());
            converter.Converters.Add(TemparatureUnit.Kelvin, new KelvinConverter());

            // ----------------------------------------------------------------

            Temperature celsiusTemperature = new Temperature(TemparatureUnit.Celsius, converter);
            celsiusTemperature.Value = 10.0M;

            decimal celsiusToFahrenheit = celsiusTemperature.To(TemparatureUnit.Fahrenheit);

            // ----------------------------------------------------------------

            Temperature fahrenheitTemperature = new Temperature(TemparatureUnit.Fahrenheit, converter);
            fahrenheitTemperature.Value = 10.0M;

            decimal fahrenheitToCelsius = fahrenheitTemperature.To(TemparatureUnit.Celsius);

            // ----------------------------------------------------------------

            Temperature kelvinTemperature = new Temperature(TemparatureUnit.Fahrenheit, converter);
            kelvinTemperature.Value = 10.0M;

            decimal kelvinToCelsius = fahrenheitTemperature.To(TemparatureUnit.Kelvin);
        }
    }
}
