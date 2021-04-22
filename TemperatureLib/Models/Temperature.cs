namespace TemperatureLib.Models
{
    public class Temperature : ITemperature
    {
        public TemparatureUnit Unit { get; }
        public decimal Value { get; set; }
        private IConverter _converter;
        public Temperature(TemparatureUnit unit, IConverter converter)
        {
            Unit = unit;
            _converter = converter;
            Value = 0.0M;
        }

        public decimal To(TemparatureUnit toTemperature)
        {
            var conversionFunc = _converter.GetConversionFunc(toTemperature);
            return conversionFunc.Invoke(Value);
        }
    }
}
