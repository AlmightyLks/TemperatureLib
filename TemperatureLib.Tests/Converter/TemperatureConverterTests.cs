using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureLib.Converters;
using TemperatureLib.Models;

namespace TemperatureLib.Tests.Converter
{
    public class TemperatureConverterTests
    {
        private const double InputValue = 10.0d;
        private const double Tolerance = 0.1d;
        [Test]
        [TestCase(InputValue, -12.22)]
        public void FromFahrenheitToCelsius(
            double input,
            double expectedOutput
            )
        {
            ITemperatureConverter converter = new FahrenheitConverter();
            Assert.AreEqual(expectedOutput, converter.FromUnitToCelsius(input), Tolerance);
        }
        [Test]
        [TestCase(InputValue, 50.0)]
        public void FromCelsiusToFahrenheit(
            double input,
            double expectedOutput
            )
        {
            ITemperatureConverter converter = new FahrenheitConverter();
            Assert.AreEqual(expectedOutput, converter.FromCelsiusToUnit(input), Tolerance);
        }

        [Test]
        [TestCase(InputValue, -263.15)]
        public void FromKelvinToCelsius(
            double input,
            double expectedOutput
            )
        {
            ITemperatureConverter converter = new KelvinConverter();
            Assert.AreEqual(expectedOutput, converter.FromUnitToCelsius(input), Tolerance);
        }
        [Test]
        [TestCase(InputValue, 283.15)]
        public void FromCelsiusToKelvin(
            double input,
            double expectedOutput
            )
        {
            ITemperatureConverter converter = new KelvinConverter();
            Assert.AreEqual(expectedOutput, converter.FromCelsiusToUnit(input), Tolerance);
        }
    }
}
