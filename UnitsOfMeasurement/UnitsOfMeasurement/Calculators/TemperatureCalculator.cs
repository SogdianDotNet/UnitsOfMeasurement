using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Models;
using UnitsOfMeasurement.Models.TemperatureScales;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement.Calculators
{
    public class TemperatureCalculator : ICalculator
    {
        public double Calculate(IUnit from, IUnit to)
        {
            if (from.GetType().IsAssignableFrom(typeof(Celsius)))
            {
                if (to.GetType().IsAssignableFrom(typeof(Fahrenheit)))
                {
                    to.Value = TemperatureFormulas.ConvertCelciusToFahrenheit(from.Value);
                    return to.Value;
                }

                if (to.GetType().IsAssignableFrom(typeof(Kelvin)))
                {
                    to.Value = TemperatureFormulas.ConvertCelsiusToKelvin(from.Value);
                    return to.Value;
                }

                if (to.GetType().IsAssignableFrom(typeof(Celsius)))
                {
                    to.Value = from.Value;
                    return to.Value;
                }
            }

            if (from.GetType().IsAssignableFrom(typeof(Fahrenheit)))
            {
                if (to.GetType().IsAssignableFrom(typeof(Celsius)))
                {
                    to.Value = TemperatureFormulas.ConvertFahrenheitToCelsius(from.Value);
                    return to.Value;
                }

                if (to.GetType().IsAssignableFrom(typeof(Kelvin)))
                {
                    to.Value = TemperatureFormulas.ConvertFahrenheitToKelvin(from.Value);
                    return to.Value;
                }

                if (to.GetType().IsAssignableFrom(typeof(Fahrenheit)))
                {
                    to.Value = from.Value;
                    return to.Value;
                }
            }

            if (from.GetType().IsAssignableFrom(typeof(Kelvin)))
            {
                if (to.GetType().IsAssignableFrom(typeof(Celsius)))
                {
                    to.Value = TemperatureFormulas.ConvertKelvinToCelsius(from.Value);
                    return to.Value;
                }

                if (to.GetType().IsAssignableFrom(typeof(Fahrenheit)))
                {
                    to.Value = TemperatureFormulas.ConvertKelvinToFahrenheit(from.Value);
                    return to.Value;
                }

                if (to.GetType().IsAssignableFrom(typeof(Kelvin)))
                {
                    to.Value = from.Value;
                    return to.Value;
                }
            }

            throw new InvalidOperationException();
        }
    }
}
