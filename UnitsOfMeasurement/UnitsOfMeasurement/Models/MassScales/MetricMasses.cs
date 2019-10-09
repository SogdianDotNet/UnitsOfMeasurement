using System;
using System.Collections.Generic;
using System.Text;
using UnitsOfMeasurement.Shared;

namespace UnitsOfMeasurement.Models.MassScales
{
    public class Kilogram : IUnit
    {
        public Mass Unit { get { return Mass.Kilogram; } }
        public double Value { get; set; }

        public string Name => Unit.ToString();
    }

    public class Gram : IUnit
    {
        public Mass Unit { get { return Mass.Gram; } }
        public double Value { get; set; }

        public string Name => Unit.ToString();
    }

    public class Milligram : IUnit
    {
        public Mass Unit { get { return Mass.Milligram; } }
        public double Value { get; set; }

        public string Name => Unit.ToString();
    }
}
