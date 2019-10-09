using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement.Models.TemperatureScales
{
    public class Celsius : IUnit
    {
        public double FreezingPoint { get { return 0.0; } }
        public Temperature Unit
        {
            get { return Temperature.Celsius; }
        }

        public double Value { get; set; }

        public string Name => Unit.ToString();
    }
}
