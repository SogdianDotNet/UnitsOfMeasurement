using System;
using System.Collections.Generic;
using System.Text;

namespace UnitsOfMeasurement.Calculators
{
    public static class MassFormulas
    {
        public static double ConvertKilogramsToPounds(double valueToConvert)
        {
            return valueToConvert * 2.20462262;
        }

        public static double ConvertKilogramsToOunces(double valueToConvert)
        {
            return valueToConvert * 35.2733686;
        }

        public static double ConvertKilogramsToStones(double valueToConvert)
        {
            return valueToConvert * 0.157473044;
        }

        public static double ConvertOuncesToKilograms(double valueToConvert)
        {
            return valueToConvert / 35.2733686;
        }

        public static double ConvertOuncesToPounds(double valueToConvert)
        {
            return valueToConvert / 16;
        }

        public static double ConvertOuncesToStones(double valueToConvert)
        {
            return valueToConvert / 223.9997849602064;
        }

        public static double ConvertPoundsToKilograms(double valueToConvert)
        {
            return valueToConvert / 2.20462262;
        }

        public static double ConvertStonesToKilograms(double valueToConvert)
        {
            return valueToConvert / 0.157473044;
        }
    }
}
