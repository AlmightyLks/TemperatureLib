using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureLib.Models
{
    public interface ITemperatureConverter
    {
        decimal FromUnitToCelsius(decimal input);
        decimal FromCelsiusToUnit(decimal input);
    }
}
