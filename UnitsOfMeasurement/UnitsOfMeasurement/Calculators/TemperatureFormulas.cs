using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsOfMeasurement.Calculators
{
    public static class TemperatureFormulas
    {
        public static double ConvertCelciusToFahrenheit(double valueToConvert)
        {
            return (valueToConvert * 1.8) + 32;
        }

        public static double ConvertCelsiusToKelvin(double valueToConvert)
        {
            return valueToConvert + 273.15;
        }

        public static double ConvertFahrenheitToCelsius(double valueToConvert)
        {
            return (valueToConvert - 32) / 1.8;
        }

        public static double ConvertFahrenheitToKelvin(double valueToConvert)
        {
            return (valueToConvert - 32) * 5 / 9 + 273.15;
        }

        public static double ConvertKelvinToCelsius(double valueToConvert)
        {
            return valueToConvert - 273.15;
        }

        public static double ConvertKelvinToFahrenheit(double valueToConvert)
        {
            return (valueToConvert - 273.15) * 9 / 5 + 32;
        }
    }
}
