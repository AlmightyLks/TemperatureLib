using NUnit.Framework;
using System.Collections.Generic;
using TemperatureLib.Converters;
using TemperatureLib.Models;

namespace TemperatureLib.Tests
{
    public class ConverterTests
    {
        private IConverter _converter;
        [SetUp]
        public void Setup()
        {
            var temperatureConverters = new Dictionary<TemparatureUnit, ITemperatureConverter>();
            temperatureConverters.Add(TemparatureUnit.Celsius, new CelsiusConverter());
            temperatureConverters.Add(TemparatureUnit.Fahrenheit, new FahrenheitConverter());
            temperatureConverters.Add(TemparatureUnit.Kelvin, new KelvinConverter());
            _converter = new Converter(temperatureConverters);
        }

        [Test]
        [TestCase(TemparatureUnit.Fahrenheit, 10.0, -12.22)]
        [TestCase(TemparatureUnit.Kelvin, 10.0, -263.15)]
        public void ConvertToCelsius(
            TemparatureUnit fromUnit,
            double input,
            double expectedOutput
            )
        {
            Assert.AreEqual(expectedOutput, _converter.Convert(fromUnit, input, TemparatureUnit.Celsius), 0.1d);
        }

        [Test]
        [TestCase(TemparatureUnit.Celsius, 10.0, 50.0)]
        [TestCase(TemparatureUnit.Kelvin, 10.0, -441.67)]
        public void ConvertToFahrenheit(
            TemparatureUnit fromUnit,
            double input,
            double expectedOutput
            )
        {
            Assert.AreEqual(expectedOutput, _converter.Convert(fromUnit, input, TemparatureUnit.Fahrenheit), 0.1d);

        }

        [Test]
        [TestCase(TemparatureUnit.Celsius, 10.0, 283.15)]
        [TestCase(TemparatureUnit.Fahrenheit, 10.0, 260.928)]
        public void ConvertToKelvin(
            TemparatureUnit fromUnit,
            double input,
            double expectedOutput
            )
        {
            Assert.AreEqual(expectedOutput, _converter.Convert(fromUnit, input, TemparatureUnit.Kelvin), 0.1d);
        }
    }
}