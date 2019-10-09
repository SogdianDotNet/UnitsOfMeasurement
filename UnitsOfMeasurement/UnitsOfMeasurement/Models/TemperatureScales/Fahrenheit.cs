using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement.Models.TemperatureScales
{
    public class Fahrenheit : IUnit
    {
        public Temperature Unit => Temperature.Fahrenheit;

        public double FreezingPoint => throw new NotImplementedException();

        public double Value { get; set; }

        public string Name => Unit.ToString();
    }
}
