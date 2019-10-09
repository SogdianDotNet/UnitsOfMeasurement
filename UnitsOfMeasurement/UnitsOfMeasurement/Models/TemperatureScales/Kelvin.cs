using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement.Models.TemperatureScales
{
    public class Kelvin : IUnit
    {
        public double FreezingPoint { get { return 0.0; } }
        public Temperature Unit
        {
            get { return Temperature.Kelvin; }
        }

        public double Value { get; set; }

        public string Name => Unit.ToString();
    }
}
