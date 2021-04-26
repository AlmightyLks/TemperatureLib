using NUnit.Framework;
using System;
using System.Collections.Generic;
using TemperatureLib.Converters;
using TemperatureLib.Models;

namespace TemperatureLib.Tests.Converter
{
    public class ConverterTests
    {
        private IConverter _converter;

        private const double InputValue = 10.0d;
        private const double Tolerance = 0.1d;

        [OneTimeSetUp]
        public void Setup()
        {
            var temperatureConverters = new Dictionary<TemparatureUnit, ITemperatureConverter>();
            temperatureConverters.Add(TemparatureUnit.Celsius, new CelsiusConverter());
            temperatureConverters.Add(TemparatureUnit.Fahrenheit, new FahrenheitConverter());
            temperatureConverters.Add(TemparatureUnit.Kelvin, new KelvinConverter());
            _converter = new Converters.Converter(temperatureConverters);
        }

        [Test]
        [TestCase(TemparatureUnit.Fahrenheit, InputValue, TemparatureUnit.Celsius, -12.22)]
        [TestCase(TemparatureUnit.Kelvin, InputValue, TemparatureUnit.Celsius, -263.15)]
        [TestCase(TemparatureUnit.Celsius, InputValue, TemparatureUnit.Fahrenheit, 50.0)]
        [TestCase(TemparatureUnit.Kelvin, InputValue, TemparatureUnit.Fahrenheit, -441.67)]
        [TestCase(TemparatureUnit.Celsius, InputValue, TemparatureUnit.Kelvin, 283.15)]
        [TestCase(TemparatureUnit.Fahrenheit, InputValue, TemparatureUnit.Kelvin, 260.928)]
        public void ConvertToExpectedValue(
            TemparatureUnit fromUnit,
            double input,
            TemparatureUnit toUnit,
            double expectedOutput
            )
        {
            //Arrange & Act
            double actual = _converter.Convert(fromUnit, input, toUnit);
            //Assert
            Assert.AreEqual(expectedOutput, actual, Tolerance);
        }

        [Test]
        [TestCase(TemparatureUnit.Celsius)]
        [TestCase(TemparatureUnit.Fahrenheit)]
        [TestCase(TemparatureUnit.Kelvin)]
        public void ThrowsWhenConvertingToSameUnit(TemparatureUnit unit)
        {
            // Arrange
            TestDelegate convertToTheSameUnit = () => _converter.Convert(unit, 0, unit);

            // Act & Assert
            Assert.Throws<ArgumentException>(convertToTheSameUnit);
        }
    }
}