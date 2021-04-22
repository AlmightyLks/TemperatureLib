namespace TemperatureLib.Models
{
    public class Temperature
    {
        public TemparatureUnit Unit { get; }
        public decimal Value
        {
            get
            {
                // When getting the value of the temperature,
                // take the backing-field celsius value and
                // convert it into whatever unit this temperature is
                return _converter.ConvertToUnit(Unit, _value);
            }
            set
            {
                // When setting this value, take the unit of this temperature
                // and take the passed value and make celsius out of it and
                // set the backing field.
                _value = _converter.ConvertToCelsius(Unit, value);
            }
        }
        private decimal _value;
        private IConverter _converter;

        public Temperature(TemparatureUnit unit, IConverter converter)
        {
            Unit = unit;
            _converter = converter;
            Value = 0.0M;
        }

        public decimal To(TemparatureUnit toUnit)
        {
            // Convert the backing field celsius value to the
            // specified unit and return the result
            return _converter.ConvertToUnit(toUnit, _value);
        }
    }
}
