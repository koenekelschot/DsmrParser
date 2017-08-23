using DsmrParser.Models;
using System;
using System.ComponentModel;
using System.Globalization;

namespace DsmrParser.Converters
{
    public class ObisTariffConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string stringValue = value as string;
            if (!string.IsNullOrWhiteSpace(stringValue))
            {
                switch (stringValue)
                {
                    case "0001":
                        return PowerTariff.Low;
                    case "0002":
                        return PowerTariff.Normal;
                    default:
                        throw new NotSupportedException($"Value {stringValue} is not a recognized ObisTariff");
                }
            }
            else
            {
                return base.ConvertFrom(context, culture, value);
            }
        }
    }
}
