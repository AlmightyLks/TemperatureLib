using TemperatureLib.Converter;
using TemperatureLib.Models;

namespace TemperatureLib.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temperatureCelsius = new Temperature(TemparatureUnit.Celsius, new CelsiusConverter());
            temperatureCelsius.Value = 15.5M;

            var valueInFahrenheit = temperatureCelsius.To(TemparatureUnit.Fahrenheit);



            Temperature temperatureFahrenheit = new Temperature(TemparatureUnit.Fahrenheit, new FahrenheitConverter());
            temperatureFahrenheit.Value = 65.5M;

            var valueInCelsius = temperatureFahrenheit.To(TemparatureUnit.Celsius);
        }
    }
}
