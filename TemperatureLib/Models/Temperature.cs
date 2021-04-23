namespace TemperatureLib.Models
{
    public class Temperature
    {
        public TemparatureUnit Unit { get; }
        public double Value { get; set; }
        private IConverter _converter;

        public Temperature(TemparatureUnit unit, IConverter converter)
        {
            Unit = unit;
            _converter = converter;
            Value = 0.0d;
        }

        public double To(TemparatureUnit toUnit)
        {
            return _converter.Convert(Unit, Value, toUnit);
        }
    }
}
